﻿using AutoMapper;
using AutoMapper.Execution;
using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PMS.Core.Models;
using PMS.Core.Models.DTO;
using PMS.Core.Models.Enum;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web.Helpers;
using UnitOfWorkDemo.Services;
using UnitOfWorkDemo.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PMS.Endpoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientRecordController : ControllerBase
    {
        public readonly IPatientRecordService _patientRecordService;
        public IMapper Mapper { get; }

        public PatientRecordController(IPatientRecordService patientRecordService , IMapper mapper)
        {
            this._patientRecordService = patientRecordService;
            Mapper = mapper;
        }

        [HttpGet("GetPatientRecordList")]
        public async Task<IActionResult> GetPatientRecordList()
        {
            var results = await _patientRecordService.GetPatientRecordsAsQuarable().ToListAsync();
            if (results == null)
            {
                return NotFound();
            }
            // Use JsonSerializerOptions with ReferenceHandler.Preserve
            var jsonOptions = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            // Serialize the results to JSON
            var json = JsonConvert.SerializeObject(results, jsonOptions);

            return Ok(JsonConvert.DeserializeObject<List<PatientMedicalRecordDetails>>(json));
        }

        [HttpGet("GetPatientRecordsBySearchString/{searchstring}")]
        public async Task<IActionResult> GetPatientRecordsBySearchString(string searchstring)
        {
            string[] searchstrings = searchstring.Split(',', '/', '|');

            var patientRecords = _patientRecordService.GetPatientRecordsAsQuarable();

            if (searchstrings.Count() >= 1 && !string.IsNullOrWhiteSpace(searchstrings[0]))
            {
                var name = searchstrings[0];
                patientRecords = patientRecords.Where(x => (x.PatientProfile.FirstName + x.PatientProfile.LastName).Contains(name));
            }

            if (searchstrings.Count() >= 2 && !string.IsNullOrWhiteSpace(searchstrings[1]))
            {
                var userId = searchstrings[1];
                patientRecords = patientRecords.Where(x => x.PatientProfileID.ToString().Contains(userId));
            }

            if (searchstrings.Count() >= 3 && !string.IsNullOrWhiteSpace(searchstrings[2]))
            {
                patientRecords = patientRecords.Where(x => x.PatientProfile.NIC.Contains(searchstrings[2], StringComparison.OrdinalIgnoreCase));
            }

            var results = patientRecords.ToList();
            if (results == null)
            {
                return NotFound();
            }
            // Use JsonSerializerOptions with ReferenceHandler.Preserve
            var jsonOptions = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            // Serialize the results to JSON
            var json = JsonConvert.SerializeObject(results, jsonOptions);

            return Ok(JsonConvert.DeserializeObject<List<PatientMedicalRecordDetails>>(json));
        }

        [HttpGet("GetFilterdPatientRecords/")]
        public async Task<IActionResult> GetFilterdPatientRecords(string? searchstring, string? patientType)
        {
            IEnumerable<spPatientMedicalRecords> result = new List<spPatientMedicalRecords>();
            try
            {
                result = await _patientRecordService.GetFilterdPatientRecords(searchstring, patientType);
            }
            catch (Exception ex)
            {
                #if DEBUG
                    Debug.WriteLine(ex);
                #endif
            }

            return Ok(result);
        }

        [HttpPost("GetPatientRecordsAsCSV/")]
        public async Task<IActionResult> GetPatientRecordsAsCSV(RecordSearchParamsDto? recordSearchParams)
        {
            var patientRecords = _patientRecordService.GetPatientRecordsAsQuarable().Include("Reason");

            if (!string.IsNullOrWhiteSpace(recordSearchParams.reason))
            {
                patientRecords = patientRecords.Where(x => x.Reason.ReasonDescription == recordSearchParams.reason);
            }

          
            if (!string.IsNullOrWhiteSpace(recordSearchParams.patientType))
            {
                PatientCategories PatientCategory = new PatientCategories();
                int patientTypeid;
                bool isvalid = int.TryParse(recordSearchParams.patientType, out patientTypeid);
                if (Enum.TryParse(typeof(PatientCategories), recordSearchParams.patientType, out var patientTypeEnum))
                {
                    PatientCategory = (PatientCategories)patientTypeEnum;

                    patientRecords = patientRecords.Where(x => x.PatientTypeID == PatientCategory);
                }
               
            }
            
           
            string[] searchstrings = recordSearchParams.searchstring!= null ? recordSearchParams.searchstring.Split(',', '/', '|') : new string[] {};

           // var patientRecords = _patientRecordService.GetPatientRecordsAsQuarable().Where(x => x.PatientTypeID == PatientCategory);

            if (searchstrings.Count() >= 1 && !string.IsNullOrWhiteSpace(searchstrings[0]))
            {
                var name = searchstrings[0];
                patientRecords = patientRecords.Where(x => (x.PatientProfile.FirstName + x.PatientProfile.LastName).Contains(name));
            }

            if (searchstrings.Count() >= 2 && !string.IsNullOrWhiteSpace(searchstrings[1]))
            {
                var userId = searchstrings[1];
                patientRecords = patientRecords.Where(x => x.PatientProfileID.ToString().Contains(userId));
            }

            if (searchstrings.Count() >= 3 && !string.IsNullOrWhiteSpace(searchstrings[2]))
            {
                patientRecords = patientRecords.Where(x => x.PatientProfile.NIC.Contains(searchstrings[2], StringComparison.OrdinalIgnoreCase));
            }



            var exportData = Mapper.Map<List<patientRecordExport>>(patientRecords.OrderByDescending(x => x.CreatedDate));
            

            if (exportData == null)
            {
                return NotFound();
            }


            //this is for testing the data

            //var patientRecord = new PatientMedicalRecordDetails() { PatientMedicalRecordID = 1, PatientProfileID = 2, BHTNumber = "12" };
            //List<PatientMedicalRecordDetails> patientMedicalRecordDetails = new List<PatientMedicalRecordDetails>();
            //patientMedicalRecordDetails.Add(patientRecord);

            byte[] bin;
            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    using (TextWriter textWriter = new StreamWriter(memoryStream))
                    using (var csvWriter = new CsvWriter(textWriter, CultureInfo.InvariantCulture))
                    {
                        //var ExportModel = _mapper.Map <List<PatientRecordExportDTO>>(results);
                        csvWriter.WriteRecords(exportData);
                      

                        //Uncomment below and 136-138 lines, commment above for testings
                        //csvWriter.WriteRecords(patientMedicalRecordDetails);
                    }

                    bin = memoryStream.ToArray();
                }
            }
            catch (Exception)
            {

                return BadRequest();
            }

            return File(bin, "application/csv", $"Patient-Records{DateTime.UtcNow}.csv");
        }

        [HttpGet("GetPatientRecordsByReason/{reason}")]
        public async Task<IActionResult> GetPatientRecordsByReason(string reason)
        {
            var results = await _patientRecordService.GetPatientRecordsAsQuarable().Where(x=> x.Reason.ReasonDescription.ToLower().Contains(reason.ToLower())).ToListAsync();

            if (results != null)
            {
                // Use JsonSerializerOptions with ReferenceHandler.Preserve
                var jsonOptions = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                };

                // Serialize the results to JSON
                var json = JsonConvert.SerializeObject(results, jsonOptions);

                return Ok(JsonConvert.DeserializeObject<List<PatientMedicalRecordDetails>>(json));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetPatientRecordsByDate/")]
        public async Task<IActionResult> GetPatientRecordsByDate(DateTime fromdate, DateTime? todate)
        {
            var results = await _patientRecordService.GetPatientRecordsAsQuarable().Where(x => x.CreatedDate>= fromdate && x.CreatedDate<=todate).ToListAsync();

            if (results != null)
            {
                // Use JsonSerializerOptions with ReferenceHandler.Preserve
                var jsonOptions = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                };

                // Serialize the results to JSON
                var json = JsonConvert.SerializeObject(results, jsonOptions);

                return Ok(JsonConvert.DeserializeObject<List<PatientMedicalRecordDetails>>(json));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetPatientRecordsByPatientType/{TypeId}")]
        public async Task<IActionResult> GetPatientRecordsByPatientType(int TypeId)
        {
            var patientTypeEnum = (PatientCategories)TypeId;
            var results = await _patientRecordService.GetPatientRecordsAsQuarable().Where(x => x.PatientTypeID == patientTypeEnum).ToListAsync();

            if (results != null)
            {
                // Use JsonSerializerOptions with ReferenceHandler.Preserve
                var jsonOptions = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                };

                // Serialize the results to JSON
                var json = JsonConvert.SerializeObject(results, jsonOptions);

                return Ok(JsonConvert.DeserializeObject<List<PatientMedicalRecordDetails>>(json));
            }
            else
            {
                return BadRequest();
            }
        }




        [HttpGet("GetPatientRecordById/{patientRecordId}")]
        public async Task<IActionResult> GetPatientRecordById(int patientId)
        {
            var patientDetails = await _patientRecordService.GetPatientRecordById(patientId);

            if (patientDetails != null)
            {
                return Ok(patientDetails);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPost("AddPatientRecord")]
        public async Task<IActionResult> AddPatientRecord([FromBody]PatientMedicalRecordDetails patientDetails)
        {

            var isPatientCreated = await _patientRecordService.CreatePatientRecord(patientDetails);

            if (isPatientCreated)
            {
                return Ok(isPatientCreated);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut("UpdatePatientRecord")]
        public async Task<IActionResult> UpdatePatientRecord(PatientMedicalRecordDetails patientDetails)
        {
            if (patientDetails != null)
            {
                var isPatientUpdated = await _patientRecordService.UpdatePatientRecord(patientDetails);
                if (isPatientUpdated)
                {
                    return Ok(isPatientUpdated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete("DeletePatientRecord/{patientRecordId}")]
        public async Task<IActionResult> DeletePatientRecord(int patientRecordId)
        {
            var isPatientRecordCreated = await _patientRecordService.DeletePatientRecord(patientRecordId);

            if (isPatientRecordCreated)
            {
                return Ok(isPatientRecordCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetRecordByPatientId/{patientRecordId}")]
        public async Task<IActionResult> GetRecordByPatientId(int patientRecordId)
        {
            var patientDetails = await _patientRecordService.GetRecordByPatientId(patientRecordId);

            if (patientDetails != null)
            {
                return Ok(patientDetails);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetPatientMedicalRecordReason/{reasonId}")]
        public async Task<IActionResult> GetPatientMedicalRecordReason(int reasonId)
        {
            var patientRecordReasons = await _patientRecordService.GetPatientMedicalReasonRecord(reasonId);

            if (patientRecordReasons != null)
            {
                return Ok(patientRecordReasons);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetPatientMedicalRecordReasonList")]
        public async Task<IActionResult> GetPatientMedicalRecordReasonList()
        {
            var patientRecordReasons = await _patientRecordService.GetPatientMedicalRecordReasonList().ToListAsync();
            if (patientRecordReasons == null)
            {
                return NotFound();
            }
            // Use JsonSerializerOptions with ReferenceHandler.Preserve
            var jsonOptions = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            // Serialize the results to JSON
            var json = JsonConvert.SerializeObject(patientRecordReasons, jsonOptions);

            return Ok(JsonConvert.DeserializeObject<List<Reason>>(json));
        }
    }
}
