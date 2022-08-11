using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueueSystem.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientAppointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketReferenceId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAppointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PatientAppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_PatientAppointments_PatientAppointmentId",
                        column: x => x.PatientAppointmentId,
                        principalTable: "PatientAppointments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PatientAppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_PatientAppointments_PatientAppointmentId",
                        column: x => x.PatientAppointmentId,
                        principalTable: "PatientAppointments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PatientAppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_PatientAppointments_PatientAppointmentId",
                        column: x => x.PatientAppointmentId,
                        principalTable: "PatientAppointments",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "PatientAppointmentId" },
                values: new object[,]
                {
                    { 1, "Sunday 9:00 AM", null },
                    { 2, "Wednesday 10:00 AM", null },
                    { 3, "Sunday 6:00 PM", null },
                    { 4, "Wednesday 7:00 PM", null }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FullName", "PatientAppointmentId", "Phone", "Specification" },
                values: new object[,]
                {
                    { new Guid("3780cee1-6799-4335-add3-141e7583c597"), "Mogtaba Saifaldeen Mohammed", null, "0928077888", "General" },
                    { new Guid("99874dbe-dd60-4bff-89d8-a82f004f1592"), "Migdam Adil Yousif", null, "0928077666", "Esoteric" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "FullName", "Gender", "PatientAppointmentId", "UserName" },
                values: new object[,]
                {
                    { new Guid("3cc375ca-23e8-4121-b1c5-801c761eb489"), "Mujab Nasraldeen Othman", "Male", null, "Mujab" },
                    { new Guid("8692ab27-d765-4584-ae3a-823fa9d37713"), "Ahmed Aziz Abas", "Male", null, "Ahmed" },
                    { new Guid("86d1513d-d609-4735-b4b7-3d8c71f0abd1"), "Waleed Mohanned Hassan", "Male", null, "Waleed" },
                    { new Guid("af6571af-33b8-49dc-a3eb-5a0c911441a8"), "Duaa Nasraldeen Othman", "Female", null, "Duaa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientAppointmentId",
                table: "Appointments",
                column: "PatientAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_PatientAppointmentId",
                table: "Doctors",
                column: "PatientAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointments_TicketReferenceId",
                table: "PatientAppointments",
                column: "TicketReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientAppointmentId",
                table: "Patients",
                column: "PatientAppointmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "PatientAppointments");
        }
    }
}
