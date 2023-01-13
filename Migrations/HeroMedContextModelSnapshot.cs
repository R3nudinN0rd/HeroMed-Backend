﻿// <auto-generated />
using System;
using HeroMed_API.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HeroMed_API.Migrations
{
    [DbContext(typeof(HeroMedContext))]
    partial class HeroMedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HeroMed_API.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentsPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmploymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SalaryCurrency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SeniorityYears")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("SectionId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0b273992-95bd-4baf-b298-92355f67b620"),
                            Address = "Arges, Pitesti, Strada Mioarei Nr1",
                            Birthdate = new DateTime(1978, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentsPath = "X://ToCompute",
                            Email = "unemail@gmail.com",
                            EmploymentDate = new DateTime(2007, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mihai",
                            Gender = "M",
                            JobId = new Guid("cdb98091-c8c1-4774-9612-57c4e6fb81f2"),
                            LastName = "Calugar",
                            Nationality = "Romanian",
                            PhoneNumber = "+40712345678",
                            PlaceOfBirth = "Arges, Pitesti, Strada Mioarei Nr. 1",
                            Salary = 7200m,
                            SalaryCurrency = "RON",
                            SectionId = new Guid("10261ba6-d3f9-48bb-b48f-12bf7a43bb82"),
                            SeniorityYears = 4
                        },
                        new
                        {
                            Id = new Guid("0b273992-95bd-4baf-b298-92355f67b621"),
                            Address = "Arges, Pitesti, Strada Mioarei Nr1",
                            Birthdate = new DateTime(1968, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentsPath = "X://ToCompute",
                            Email = "altemail@gmail.com",
                            EmploymentDate = new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "George",
                            Gender = "M",
                            JobId = new Guid("cdb98091-c8c1-4774-9612-57c4e6fb81f2"),
                            LastName = "Patrar",
                            Nationality = "Romanian",
                            PhoneNumber = "+40723456789",
                            PlaceOfBirth = "Bucurest, Sectorul 1, O strada nr 3",
                            Salary = 29000m,
                            SalaryCurrency = "RON",
                            SectionId = new Guid("10261ba6-d3f9-48bb-b48f-12bf7a43bb83"),
                            SeniorityYears = 22
                        },
                        new
                        {
                            Id = new Guid("0b273992-95bd-4baf-b298-92355f67b622"),
                            Address = "Arges, Pitesti, Strada Mioarei Nr1",
                            Birthdate = new DateTime(1978, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentsPath = "X://ToCompute",
                            Email = "unemail@gmail.com",
                            EmploymentDate = new DateTime(2007, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mihai",
                            Gender = "M",
                            JobId = new Guid("cdb98091-c8c1-4774-9612-57c4e6fb81f3"),
                            LastName = "Calugar",
                            Nationality = "Romanian",
                            PhoneNumber = "+40712345678",
                            PlaceOfBirth = "Arges, Pitesti, Strada Mioarei Nr. 1",
                            Salary = 7200m,
                            SalaryCurrency = "RON",
                            SectionId = new Guid("10261ba6-d3f9-48bb-b48f-12bf7a43bb84"),
                            SeniorityYears = 4
                        },
                        new
                        {
                            Id = new Guid("0b273992-95bd-4baf-b298-92355f67b600"),
                            Address = " ",
                            Birthdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentsPath = "X://ToCompute",
                            Email = "remusene69@gmail.com",
                            EmploymentDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "admin",
                            Gender = " ",
                            JobId = new Guid("cdb98091-c8c1-4774-9612-57c4e6fb81f3"),
                            LastName = "admin",
                            Nationality = " ",
                            PhoneNumber = "+40751862506",
                            PlaceOfBirth = " ",
                            Salary = 0m,
                            SalaryCurrency = "RON",
                            SectionId = new Guid("10261ba6-d3f9-48bb-b48f-12bf7a43bb84"),
                            SeniorityYears = 10
                        });
                });

            modelBuilder.Entity("HeroMed_API.Entities.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AnnualPaidLeave")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MaxBruteSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinBruteSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MinISCEDLevel")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkHoursPerMonth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cdb98091-c8c1-4774-9612-57c4e6fb81f2"),
                            AnnualPaidLeave = 22,
                            Currency = "RON",
                            Description = "It usually assists the higher grades and leads to the fulfillment of easy tasks (harvests, vaccines, etc.)",
                            MaxBruteSalary = 12368m,
                            MinBruteSalary = 7094m,
                            MinISCEDLevel = 6,
                            Title = "Nurse",
                            WorkHoursPerMonth = 180
                        },
                        new
                        {
                            Id = new Guid("cdb98091-c8c1-4774-9612-57c4e6fb81f3"),
                            AnnualPaidLeave = 22,
                            Currency = "RON",
                            Description = "He deals with the inventory and distribution of medicines inside unit.",
                            MaxBruteSalary = 12614m,
                            MinBruteSalary = 4227m,
                            MinISCEDLevel = 6,
                            Title = "Chemist",
                            WorkHoursPerMonth = 180
                        },
                        new
                        {
                            Id = new Guid("cdb98091-c8c1-4774-9612-57c4e6fb81f4"),
                            AnnualPaidLeave = 22,
                            Currency = "RON",
                            Description = "He takes care of heavy tasks. It usually represents the penultimate grade after the department head.",
                            MaxBruteSalary = 26986m,
                            MinBruteSalary = 7000m,
                            MinISCEDLevel = 8,
                            Title = "Primary doctor",
                            WorkHoursPerMonth = 180
                        },
                        new
                        {
                            Id = new Guid("cdb98091-c8c1-4774-9612-57c4e6fb81f5"),
                            AnnualPaidLeave = 22,
                            Currency = "RON",
                            Description = "He coordinates the whole department.",
                            MaxBruteSalary = 29795m,
                            MinBruteSalary = 28795m,
                            MinISCEDLevel = 8,
                            Title = "Head of department",
                            WorkHoursPerMonth = 180
                        });
                });

            modelBuilder.Entity("HeroMed_API.Entities.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DischargeDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EnrolledDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssueDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SalonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SalonId");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7b7e16ec-2672-4360-ad3d-4941d5d08742"),
                            Address = "Str. Nicolae Balcescu, Nr. 189, Blc. L6, Sc. A, Ap. 20",
                            BirthDate = new DateTimeOffset(new DateTime(1999, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            DischargeDate = new DateTimeOffset(new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Email = "mircea.popa@gmail.com",
                            EmergencyContactName = "Rares Popa",
                            EmergencyContactPhoneNumber = "0752345678",
                            EnrolledDate = new DateTimeOffset(new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Mircea",
                            IssueDetails = "Some disease details.",
                            LastName = "Popa",
                            PhoneNumber = "0751234567",
                            SalonId = new Guid("46589e47-e79f-417f-9e1a-410dd719f0e8")
                        },
                        new
                        {
                            Id = new Guid("7b7e16ec-2672-4360-ad3d-4941d5d08743"),
                            Address = "Str. Nicolae Balcescu, Nr. 1, Blc. L4, Sc. B, Ap. 14",
                            BirthDate = new DateTimeOffset(new DateTime(1997, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            DischargeDate = new DateTimeOffset(new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Email = "mircea.popa@gmail.com",
                            EmergencyContactName = "Rares Voicu",
                            EmergencyContactPhoneNumber = "0752345123",
                            EnrolledDate = new DateTimeOffset(new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Radu",
                            IssueDetails = "Some disease details. 2",
                            LastName = "Voicu",
                            PhoneNumber = "0752234567",
                            SalonId = new Guid("46589e47-e79f-417f-9e1a-410dd719f0e8")
                        },
                        new
                        {
                            Id = new Guid("7b7e16ec-2672-4360-ad3d-4941d5d08744"),
                            Address = "Str. Nicolae Balcescu, Nr. 189, Blc. L6, Sc. A, Ap. 20",
                            BirthDate = new DateTimeOffset(new DateTime(2001, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            DischargeDate = new DateTimeOffset(new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Email = "mircea.popa@gmail.com",
                            EmergencyContactName = "Rares Popa",
                            EmergencyContactPhoneNumber = "0758765432",
                            EnrolledDate = new DateTimeOffset(new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Mircea2",
                            IssueDetails = "Some disease details.",
                            LastName = "Popa2",
                            PhoneNumber = "0751232222",
                            SalonId = new Guid("46589e47-e79f-417f-9e1a-410dd719f0e8")
                        });
                });

            modelBuilder.Entity("HeroMed_API.Entities.RelationsEntity.PatientEmployee", b =>
                {
                    b.Property<Guid>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PatientId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("PatientEmployee");

                    b.HasData(
                        new
                        {
                            PatientId = new Guid("7b7e16ec-2672-4360-ad3d-4941d5d08742"),
                            EmployeeId = new Guid("0b273992-95bd-4baf-b298-92355f67b620")
                        },
                        new
                        {
                            PatientId = new Guid("7b7e16ec-2672-4360-ad3d-4941d5d08742"),
                            EmployeeId = new Guid("0b273992-95bd-4baf-b298-92355f67b621")
                        },
                        new
                        {
                            PatientId = new Guid("7b7e16ec-2672-4360-ad3d-4941d5d08742"),
                            EmployeeId = new Guid("0b273992-95bd-4baf-b298-92355f67b622")
                        },
                        new
                        {
                            PatientId = new Guid("7b7e16ec-2672-4360-ad3d-4941d5d08743"),
                            EmployeeId = new Guid("0b273992-95bd-4baf-b298-92355f67b621")
                        },
                        new
                        {
                            PatientId = new Guid("7b7e16ec-2672-4360-ad3d-4941d5d08743"),
                            EmployeeId = new Guid("0b273992-95bd-4baf-b298-92355f67b620")
                        },
                        new
                        {
                            PatientId = new Guid("7b7e16ec-2672-4360-ad3d-4941d5d08744"),
                            EmployeeId = new Guid("0b273992-95bd-4baf-b298-92355f67b620")
                        });
                });

            modelBuilder.Entity("HeroMed_API.Entities.Salon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("Beds")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<Guid>("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Salon");

                    b.HasData(
                        new
                        {
                            Id = new Guid("46589e47-e79f-417f-9e1a-410dd719f0e6"),
                            Available = true,
                            Beds = 4,
                            Floor = 2,
                            SectionId = new Guid("10261ba6-d3f9-48bb-b48f-12bf7a43bb82")
                        },
                        new
                        {
                            Id = new Guid("46589e47-e79f-417f-9e1a-410dd719f0e7"),
                            Available = true,
                            Beds = 3,
                            Floor = 1,
                            SectionId = new Guid("10261ba6-d3f9-48bb-b48f-12bf7a43bb83")
                        },
                        new
                        {
                            Id = new Guid("46589e47-e79f-417f-9e1a-410dd719f0e8"),
                            Available = true,
                            Beds = 4,
                            Floor = 1,
                            SectionId = new Guid("10261ba6-d3f9-48bb-b48f-12bf7a43bb83")
                        });
                });

            modelBuilder.Entity("HeroMed_API.Entities.Section", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaximumEmployeesNo")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sections");

                    b.HasData(
                        new
                        {
                            Id = new Guid("10261ba6-d3f9-48bb-b48f-12bf7a43bb82"),
                            Description = "This section deals with diseas related to the heart.",
                            MaximumEmployeesNo = 5,
                            Title = "Cardiology"
                        },
                        new
                        {
                            Id = new Guid("10261ba6-d3f9-48bb-b48f-12bf7a43bb83"),
                            Description = "This section deals with diseases related to the nervous system.",
                            MaximumEmployeesNo = 3,
                            Title = "Neurology"
                        },
                        new
                        {
                            Id = new Guid("10261ba6-d3f9-48bb-b48f-12bf7a43bb84"),
                            Description = "This section deals with diseases related to the respiratory system.",
                            MaximumEmployeesNo = 6,
                            Title = "Pneumology"
                        },
                        new
                        {
                            Id = new Guid("10261ba6-d3f9-48bb-b48f-12bf7a43bb85"),
                            Description = "This section deals with radiographs.",
                            MaximumEmployeesNo = 9,
                            Title = "Radiology"
                        });
                });

            modelBuilder.Entity("HeroMed_API.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1fdbe311-ac30-4a06-be2c-0fcc779b9246"),
                            Admin = true,
                            CreatedDate = new DateTime(2022, 12, 12, 21, 25, 36, 967, DateTimeKind.Local).AddTicks(9042),
                            EmployeeId = new Guid("0b273992-95bd-4baf-b298-92355f67b600"),
                            Password = "admin",
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("1fdbe311-ac30-4a06-be2c-0fcc779b9247"),
                            Admin = false,
                            CreatedDate = new DateTime(2022, 12, 12, 21, 25, 36, 967, DateTimeKind.Local).AddTicks(9079),
                            EmployeeId = new Guid("0b273992-95bd-4baf-b298-92355f67b620"),
                            Password = "OParola",
                            Username = "UnUSername"
                        },
                        new
                        {
                            Id = new Guid("1fdbe311-ac30-4a06-be2c-0fcc779b9248"),
                            Admin = false,
                            CreatedDate = new DateTime(2022, 12, 12, 21, 25, 36, 967, DateTimeKind.Local).AddTicks(9081),
                            EmployeeId = new Guid("0b273992-95bd-4baf-b298-92355f67b621"),
                            Password = "AltaParola",
                            Username = "AltUSername"
                        });
                });

            modelBuilder.Entity("HeroMed_API.Entities.Employee", b =>
                {
                    b.HasOne("HeroMed_API.Entities.Job", "Job")
                        .WithMany("Employees")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HeroMed_API.Entities.Section", "Section")
                        .WithMany("Employees")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("HeroMed_API.Entities.Patient", b =>
                {
                    b.HasOne("HeroMed_API.Entities.Salon", "Salon")
                        .WithMany("Patient")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("HeroMed_API.Entities.RelationsEntity.PatientEmployee", b =>
                {
                    b.HasOne("HeroMed_API.Entities.Employee", "Employee")
                        .WithMany("EmployeePatients")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("HeroMed_API.Entities.Patient", "Patient")
                        .WithMany("PatientEmployees")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HeroMed_API.Entities.Salon", b =>
                {
                    b.HasOne("HeroMed_API.Entities.Section", "Section")
                        .WithMany("Salon")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");
                });

            modelBuilder.Entity("HeroMed_API.Entities.User", b =>
                {
                    b.HasOne("HeroMed_API.Entities.Employee", "AccountOf")
                        .WithOne("User")
                        .HasForeignKey("HeroMed_API.Entities.User", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountOf");
                });

            modelBuilder.Entity("HeroMed_API.Entities.Employee", b =>
                {
                    b.Navigation("EmployeePatients");

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("HeroMed_API.Entities.Job", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("HeroMed_API.Entities.Patient", b =>
                {
                    b.Navigation("PatientEmployees");
                });

            modelBuilder.Entity("HeroMed_API.Entities.Salon", b =>
                {
                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HeroMed_API.Entities.Section", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Salon");
                });
#pragma warning restore 612, 618
        }
    }
}
