﻿
using System;
using CrudIntelectah.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudIntelectah.Migrations
{
    [DbContext(typeof(PatientDbContext))]
    [Migration("20220529184854_initialcreation")]
    partial class initialcreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CrudIntelectah.Models.AppointmentScheduling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ConsultationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ExamRecordId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PatientId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProtocolNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AppointmentsScheduling");
                });

            modelBuilder.Entity("CrudIntelectah.Models.ExamRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observation")
                        .HasColumnType("TEXT");

                    b.Property<int>("TypeOfExamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ExamRecords");
                });

            modelBuilder.Entity("CrudIntelectah.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("CrudIntelectah.Models.TypeOfExam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TypeOfExams");
                });
        }
    }
}
