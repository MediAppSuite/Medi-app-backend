﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitOfWorkDemo.Infrastructure;

#nullable disable

namespace PMS.Infrastructure.Migrations
{
    [DbContext(typeof(DbContextClass))]
    [Migration("20231116174545_NIC number added")]
    partial class NICnumberadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PMS.Core.Models.PatientMedicalRecordDetails", b =>
                {
                    b.Property<long>("PatientMedicalRecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PatientMedicalRecordID"), 1L, 1);

                    b.Property<long>("BHTNumber")
                        .HasColumnType("bigint");

                    b.Property<double?>("BMI")
                        .HasColumnType("float");

                    b.Property<string>("BloodLossInTheDrainD1_D2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodLossInTheDrainD2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoneAvolsion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChestComplications_1st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChestComplications_2st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChestComplications_Intermediate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChestComplications_Late")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DLD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateofSurgery")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeepWoundInfections_1st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeepWoundInfections_2nd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeepWoundInfections_Intermediate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeepWoundInfections_Late")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EffectivenessInMobilization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatEmbolism_1st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatEmbolism_2st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatEmbolism_2st_Intermediate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatEmbolism_Late")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Height_cm")
                        .HasColumnType("float");

                    b.Property<string>("Hematoma_1st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hematoma_2st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hematoma_Intermediate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hematoma_Late")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hepato_Gastrointestinal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HxOfOtherMSKInjuriesAndPains")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hypertension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IatrogenicFactors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndicationForAdmissionToTheICU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndicationForTheSurgery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsDeleted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IschemicHeartDiseases")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LigametAvulsions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("N0ofPostOpFFPTransfussions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOofPostOpBloodTransfussions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoofDaysInTheHospital")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoofDaysInTheICU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherBoneDissordersInLimbs_congenital")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherBoneDissordersInLimbs_traumatic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Others")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PainTolerance_PostOpD1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PainTolerance_beforeDischarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientProfileID")
                        .HasColumnType("int");

                    b.Property<int>("PatientTypeID")
                        .HasColumnType("int");

                    b.Property<string>("PerOperativeBloodLoss")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeripheralNeuropathies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD3BP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD3BloodUrea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD3FBS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD3HB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD3HR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD3NeutrophilCount_103_uL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD3RR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD3SerumCreatinine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD3SerumK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD3SerumNa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD3WBC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD5BP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD5BloodUrea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD5FBS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD5HB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD5HR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD5Neutrophil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD5RR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD5SerumCreatinine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD5SerumK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD5SerumNa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpD5WBC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpDay1BP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpDay1BloodUrea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpDay1FBS_mg_dL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpDay1HB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpDay1HR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpDay1Neutrophil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpDay1RR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpDay1SerumCreatinine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpDay1SerumK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpDay1SerumNa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostOpDay1WBC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreOpBP_mmHg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreOpBloodUrea_mg_dL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreOpFBS_mg_dL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreOpHB_g_dL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreOpHR_bpm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreOpK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreOpNa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreOpNeutrophilCount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreOpRR_bpm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreOpSCcreatinine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreOpWBC_103")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuadricepMuscleRupture_1st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuadricepMuscleRupture_2st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuadricepMuscleRupture_Intermediate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuadricepMuscleRupture_Late")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ReasonID")
                        .HasColumnType("bigint");

                    b.Property<string>("Renal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Respiratory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinOpening_1st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinOpening_2st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinOpening_Intermediate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinOpening_Late")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stroke")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuperficialWoundInfections_1st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuperficialWoundInfections_2nd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuperficialWoundInfections_Intermediate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuperficialWoundInfections_Late")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surgery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurgicalWoundComplication_1st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurgicalWoundComplication_2st")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurgicalWoundComplication_Intermediate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurgicalWoundComplication_Late")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thyroid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TorniquetTimeMin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalOperativeRoomTime_min")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranexamicAcidGivenOrNot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Weight_kg")
                        .HasColumnType("float");

                    b.HasKey("PatientMedicalRecordID");

                    b.HasIndex("PatientProfileID");

                    b.HasIndex("ReasonID");

                    b.ToTable("PatientRecord");
                });

            modelBuilder.Entity("PMS.Core.Models.Reason", b =>
                {
                    b.Property<long>("ReasonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ReasonID"), 1L, 1);

                    b.Property<string>("ReasonDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReasonID");

                    b.ToTable("Reason");
                });

            modelBuilder.Entity("UnitOfWorkDemo.Core.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Allergic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmergencyContactNo")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalHistory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PMS.Core.Models.PatientMedicalRecordDetails", b =>
                {
                    b.HasOne("UnitOfWorkDemo.Core.Models.Patient", "PatientProfile")
                        .WithMany("PatientMedicalRecordDetails")
                        .HasForeignKey("PatientProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS.Core.Models.Reason", "Reason")
                        .WithMany()
                        .HasForeignKey("ReasonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PatientProfile");

                    b.Navigation("Reason");
                });

            modelBuilder.Entity("UnitOfWorkDemo.Core.Models.Patient", b =>
                {
                    b.Navigation("PatientMedicalRecordDetails");
                });
#pragma warning restore 612, 618
        }
    }
}