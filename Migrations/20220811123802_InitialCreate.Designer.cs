// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QueueSystem.API.Models;

#nullable disable

namespace QueueSystem.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220811123802_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QueueSystem.API.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AppointmentDate")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid?>("PatientAppointmentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PatientAppointmentId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppointmentDate = "Sunday 9:00 AM"
                        },
                        new
                        {
                            Id = 3,
                            AppointmentDate = "Sunday 6:00 PM"
                        },
                        new
                        {
                            Id = 2,
                            AppointmentDate = "Wednesday 10:00 AM"
                        },
                        new
                        {
                            Id = 4,
                            AppointmentDate = "Wednesday 7:00 PM"
                        });
                });

            modelBuilder.Entity("QueueSystem.API.Models.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid?>("PatientAppointmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Specification")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("PatientAppointmentId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("99874dbe-dd60-4bff-89d8-a82f004f1592"),
                            FullName = "Migdam Adil Yousif",
                            Phone = "0928077666",
                            Specification = "Esoteric"
                        },
                        new
                        {
                            Id = new Guid("3780cee1-6799-4335-add3-141e7583c597"),
                            FullName = "Mogtaba Saifaldeen Mohammed",
                            Phone = "0928077888",
                            Specification = "General"
                        });
                });

            modelBuilder.Entity("QueueSystem.API.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid?>("PatientAppointmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("PatientAppointmentId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("86d1513d-d609-4735-b4b7-3d8c71f0abd1"),
                            FullName = "Waleed Mohanned Hassan",
                            Gender = "Male",
                            UserName = "Waleed"
                        },
                        new
                        {
                            Id = new Guid("8692ab27-d765-4584-ae3a-823fa9d37713"),
                            FullName = "Ahmed Aziz Abas",
                            Gender = "Male",
                            UserName = "Ahmed"
                        },
                        new
                        {
                            Id = new Guid("af6571af-33b8-49dc-a3eb-5a0c911441a8"),
                            FullName = "Duaa Nasraldeen Othman",
                            Gender = "Female",
                            UserName = "Duaa"
                        },
                        new
                        {
                            Id = new Guid("3cc375ca-23e8-4121-b1c5-801c761eb489"),
                            FullName = "Mujab Nasraldeen Othman",
                            Gender = "Male",
                            UserName = "Mujab"
                        });
                });

            modelBuilder.Entity("QueueSystem.API.Models.PatientAppointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TicketReferenceId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("TicketReferenceId");

                    b.ToTable("PatientAppointments");
                });

            modelBuilder.Entity("QueueSystem.API.Models.Appointment", b =>
                {
                    b.HasOne("QueueSystem.API.Models.PatientAppointment", null)
                        .WithMany("Appointment")
                        .HasForeignKey("PatientAppointmentId");
                });

            modelBuilder.Entity("QueueSystem.API.Models.Doctor", b =>
                {
                    b.HasOne("QueueSystem.API.Models.PatientAppointment", null)
                        .WithMany("Doctor")
                        .HasForeignKey("PatientAppointmentId");
                });

            modelBuilder.Entity("QueueSystem.API.Models.Patient", b =>
                {
                    b.HasOne("QueueSystem.API.Models.PatientAppointment", null)
                        .WithMany("Patient")
                        .HasForeignKey("PatientAppointmentId");
                });

            modelBuilder.Entity("QueueSystem.API.Models.PatientAppointment", b =>
                {
                    b.Navigation("Appointment");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
