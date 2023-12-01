﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Infrastructure.Migrations
{
    public partial class PatientMedicalRecordDetailsFilterationStoredProcedureAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "spPatientMedicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientMedicalRecordID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allergic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    insuranceInfomation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PatientTypeID = table.Column<int>(type: "int", nullable: false),
                    BHTNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReasonDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicationForTheSurgery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicationForAdmissionToTheICU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranexamicAcidGivenOrNot = table.Column<bool>(type: "bit", nullable: true),
                    PreOpBP_mmHg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpHR_bpm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpRR_bpm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpBloodUrea_mg_dL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpNa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpSCcreatinine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpHB_g_dL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpWBC_103 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpFBS_mg_dL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreOpNeutrophilCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1BP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1HR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1RR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1BloodUrea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1SerumNa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1SerumK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1SerumCreatinine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1HB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1WBC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1FBS_mg_dL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpDay1Neutrophil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3BP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3HR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3RR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3BloodUrea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3SerumNa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3SerumK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3SerumCreatinine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3HB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3WBC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3FBS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD3NeutrophilCount_103_uL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5BP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5HR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5RR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5BloodUrea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5SerumNa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5SerumK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5SerumCreatinine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5HB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5WBC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5FBS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostOpD5Neutrophil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height_cm = table.Column<double>(type: "float", nullable: true),
                    Weight_kg = table.Column<double>(type: "float", nullable: true),
                    BMI = table.Column<double>(type: "float", nullable: true),
                    DateofSurgery = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Hypertension = table.Column<bool>(type: "bit", nullable: false),
                    DLD = table.Column<bool>(type: "bit", nullable: true),
                    DM = table.Column<bool>(type: "bit", nullable: true),
                    Thyroid = table.Column<bool>(type: "bit", nullable: true),
                    Others = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IschemicHeartDiseases = table.Column<bool>(type: "bit", nullable: true),
                    Other1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeripheralNeuropathies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stroke = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherBoneDissordersInLimbs_congenital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherBoneDissordersInLimbs_traumatic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HxOfOtherMSKInjuriesAndPains = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hepato_Gastrointestinal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Respiratory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Renal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerOperativeBloodLoss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodLossInTheDrainD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodLossInTheDrainD1_D2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TorniquetTimeMin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOofPostOpBloodTransfussions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N0ofPostOpFFPTransfussions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalOperativeRoomTime_min = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoneAvolsion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LigametAvulsions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IatrogenicFactors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperficialWoundInfections_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeepWoundInfections_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuadricepMuscleRupture_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkinOpening_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatEmbolism_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgicalWoundComplication_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hematoma_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChestComplications_1st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperficialWoundInfections_2nd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeepWoundInfections_2nd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuadricepMuscleRupture_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkinOpening_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatEmbolism_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgicalWoundComplication_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hematoma_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChestComplications_2st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperficialWoundInfections_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeepWoundInfections_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuadricepMuscleRupture_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkinOpening_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatEmbolism_2st_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgicalWoundComplication_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hematoma_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChestComplications_Intermediate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperficialWoundInfections_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeepWoundInfections_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuadricepMuscleRupture_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkinOpening_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatEmbolism_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgicalWoundComplication_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hematoma_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChestComplications_Late = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PainTolerance_PostOpD1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PainTolerance_beforeDischarge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoofDaysInTheICU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectivenessInMobilization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoofDaysInTheHospital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalRecordUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalRecordFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spPatientMedicalRecords", x => x.Id);
                });

            migrationBuilder.Sql("-- ================================================\r\nSET ANSI_NULLS ON\r\nGO\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\n-- =============================================\r\n-- Author : Chamod Devinda N.M \r\n-- Create date : 2023-12-02\r\n-- Description : \r\n-- =============================================\r\nCREATE PROCEDURE spGetFilterdPatientRecords\r\n -- Add the parameters for the stored procedure here\r\n @UserName nvarchar(200) = NULL,\r\n @ProfileId nvarchar(2) = NULL,\r\n @NIC nvarchar(50) = NULL,\r\n @PatientType int = NULL,\r\n @MobileNumber nvarchar(20) = NULL\r\nAS\r\nBEGIN\r\n SELECT TOP (1000) [PatientMedicalRecordID]\r\n ,p.[Id]\r\n ,p.[FirstName]\r\n ,p.[LastName]\r\n ,p.[DateOfBirth]\r\n ,p.[NIC]\r\n ,p.[Gender]\r\n ,p.[ContactNumber]\r\n ,p.[Address]\r\n ,p.[EmergencyContactNo]\r\n ,p.[BloodGroup]\r\n ,p.[MedicalHistory]\r\n ,p.[Allergic]\r\n ,p.[insuranceInfomation]\r\n ,p.[isActive]\r\n ,p.[RegisteredDate]\r\n ,pr.[PatientTypeID]\r\n ,pr.[BHTNumber]\r\n ,r.[ReasonDescription]\r\n ,pr.[Surgery]\r\n ,pr.[IndicationForTheSurgery]\r\n ,pr.[IndicationForAdmissionToTheICU]\r\n ,pr.[TranexamicAcidGivenOrNot]\r\n ,pr.[PreOpBP_mmHg]\r\n ,pr.[PreOpHR_bpm]\r\n ,pr.[PreOpRR_bpm]\r\n ,pr.[PreOpBloodUrea_mg_dL]\r\n ,pr.[PreOpNa]\r\n ,pr.[PreOpK]\r\n ,pr.[PreOpSCcreatinine]\r\n ,pr.[PreOpHB_g_dL]\r\n ,pr.[PreOpWBC_103]\r\n ,pr.[PreOpFBS_mg_dL]\r\n ,pr.[PreOpNeutrophilCount]\r\n ,pr.[PostOpDay1BP]\r\n ,pr.[PostOpDay1HR]\r\n ,pr.[PostOpDay1RR]\r\n ,pr.[PostOpDay1BloodUrea]\r\n ,pr.[PostOpDay1SerumNa]\r\n ,pr.[PostOpDay1SerumK]\r\n ,pr.[PostOpDay1SerumCreatinine]\r\n ,pr.[PostOpDay1HB]\r\n ,pr.[PostOpDay1WBC]\r\n ,pr.[PostOpDay1FBS_mg_dL]\r\n ,pr.[PostOpDay1Neutrophil]\r\n ,pr.[PostOpD3BP]\r\n ,pr.[PostOpD3HR]\r\n ,pr.[PostOpD3RR]\r\n ,pr.[PostOpD3BloodUrea]\r\n ,pr.[PostOpD3SerumNa]\r\n ,pr.[PostOpD3SerumK]\r\n ,pr.[PostOpD3SerumCreatinine]\r\n ,pr.[PostOpD3HB]\r\n ,pr.[PostOpD3WBC]\r\n ,pr.[PostOpD3FBS]\r\n ,pr.[PostOpD3NeutrophilCount_103_uL]\r\n ,pr.[PostOpD5BP]\r\n ,pr.[PostOpD5HR]\r\n ,pr.[PostOpD5RR]\r\n ,pr.[PostOpD5BloodUrea]\r\n ,pr.[PostOpD5SerumNa]\r\n ,pr.[PostOpD5SerumK]\r\n ,pr.[PostOpD5SerumCreatinine]\r\n ,pr.[PostOpD5HB]\r\n ,pr.[PostOpD5WBC]\r\n ,pr.[PostOpD5FBS]\r\n ,pr.[PostOpD5Neutrophil]\r\n ,pr.[Height_cm]\r\n ,pr.[Weight_kg]\r\n ,pr.[BMI]\r\n ,pr.[DateofSurgery]\r\n ,pr.[Hypertension]\r\n ,pr.[DLD]\r\n ,pr.[DM]\r\n ,pr.[Thyroid]\r\n ,pr.[Others]\r\n ,pr.[IschemicHeartDiseases]\r\n ,pr.[Other1]\r\n ,pr.[Other2]\r\n ,pr.[PeripheralNeuropathies]\r\n ,pr.[Stroke]\r\n ,pr.[OtherBoneDissordersInLimbs_congenital]\r\n ,pr.[OtherBoneDissordersInLimbs_traumatic]\r\n ,pr.[HxOfOtherMSKInjuriesAndPains]\r\n ,pr.[Hepato_Gastrointestinal]\r\n ,pr.[Respiratory]\r\n ,pr.[Renal]\r\n ,pr.[Other]\r\n ,pr.[PerOperativeBloodLoss]\r\n ,pr.[BloodLossInTheDrainD2]\r\n ,pr.[BloodLossInTheDrainD1_D2]\r\n ,pr.[TorniquetTimeMin]\r\n ,pr.[NOofPostOpBloodTransfussions]\r\n ,pr.[N0ofPostOpFFPTransfussions]\r\n ,pr.[TotalOperativeRoomTime_min]\r\n ,pr.[BoneAvolsion]\r\n ,pr.[LigametAvulsions]\r\n ,pr.[IatrogenicFactors]\r\n ,pr.[SuperficialWoundInfections_1st]\r\n ,pr.[DeepWoundInfections_1st]\r\n ,pr.[QuadricepMuscleRupture_1st]\r\n ,pr.[SkinOpening_1st]\r\n ,pr.[FatEmbolism_1st]\r\n ,pr.[SurgicalWoundComplication_1st]\r\n ,pr.[Hematoma_1st]\r\n ,pr.[ChestComplications_1st]\r\n ,pr.[SuperficialWoundInfections_2nd]\r\n ,pr.[DeepWoundInfections_2nd]\r\n ,pr.[QuadricepMuscleRupture_2st]\r\n ,pr.[SkinOpening_2st]\r\n ,pr.[FatEmbolism_2st]\r\n ,pr.[SurgicalWoundComplication_2st]\r\n ,pr.[Hematoma_2st]\r\n ,pr.[ChestComplications_2st]\r\n ,pr.[SuperficialWoundInfections_Intermediate]\r\n ,pr.[DeepWoundInfections_Intermediate]\r\n ,pr.[QuadricepMuscleRupture_Intermediate]\r\n ,pr.[SkinOpening_Intermediate]\r\n ,pr.[FatEmbolism_2st_Intermediate]\r\n ,pr.[SurgicalWoundComplication_Intermediate]\r\n ,pr.[Hematoma_Intermediate]\r\n ,pr.[ChestComplications_Intermediate]\r\n ,pr.[SuperficialWoundInfections_Late]\r\n ,pr.[DeepWoundInfections_Late]\r\n ,pr.[QuadricepMuscleRupture_Late]\r\n ,pr.[SkinOpening_Late]\r\n ,pr.[FatEmbolism_Late]\r\n ,pr.[SurgicalWoundComplication_Late]\r\n ,pr.[Hematoma_Late]\r\n ,pr.[ChestComplications_Late]\r\n ,pr.[PainTolerance_PostOpD1]\r\n ,pr.[PainTolerance_beforeDischarge]\r\n ,pr.[NoofDaysInTheICU]\r\n ,pr.[EffectivenessInMobilization]\r\n ,pr.[NoofDaysInTheHospital]\r\n ,pr.[CreatedDate]\r\n ,pr.[CreatedBy]\r\n ,pr.[ModifiedDate]\r\n ,pr.[ModifiedBy]\r\n ,pr.[IsDeleted]\r\n ,pr.[DeletedDate]\r\n ,pr.[DeletedBy]\r\n ,pr.[MedicalRecordUrl]\r\n ,pr.[medicalRecordFileName]\r\n FROM [dbo].[PatientRecord] as pr INNER JOIN [dbo].[Patients] as p on pr.PatientProfileID = p.Id\r\n INNER JOIN [dbo].[Reasons] as r on pr.ReasonID = r.ReasonID\r\n WHERE \r\n ( @UserName IS NULL OR @UserName = '' OR CONCAT(p.FirstName, ' ', p.LastName) LIKE '%' + @UserName + '%' )\r\n AND ( @ProfileId IS NULL OR @ProfileId = '' OR p.Id LIKE '%' + @ProfileId + '%' )\r\n AND ( @NIC IS NULL OR @NIC = '' OR p.NIC LIKE '%' + @NIC + '%' )\r\n AND ( @PatientType IS NULL OR pr.PatientTypeID = @PatientType )\r\n AND ( @MobileNumber IS NULL OR @MobileNumber = '' OR p.ContactNumber LIKE '%' + @MobileNumber + '%' );\r\n\r\nEND\r\nGO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "spPatientMedicalRecords");

            migrationBuilder.Sql("DROP PROCEDURE spGetFilterdPatientRecords;");

        }
    }
}
