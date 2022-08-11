using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueueSystem.API.Migrations
{
    public partial class FixPatientAppointmentTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_PatientAppointments_PatientAppointmentId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_PatientAppointments_PatientAppointmentId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_PatientAppointments_PatientAppointmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PatientAppointmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_PatientAppointmentId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PatientAppointmentId",
                table: "Appointments");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("3780cee1-6799-4335-add3-141e7583c597"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("99874dbe-dd60-4bff-89d8-a82f004f1592"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3cc375ca-23e8-4121-b1c5-801c761eb489"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("8692ab27-d765-4584-ae3a-823fa9d37713"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("86d1513d-d609-4735-b4b7-3d8c71f0abd1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("af6571af-33b8-49dc-a3eb-5a0c911441a8"));

            migrationBuilder.DropColumn(
                name: "PatientAppointmentId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientAppointmentId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PatientAppointmentId",
                table: "Appointments");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FullName", "Phone", "Specification" },
                values: new object[,]
                {
                    { new Guid("daa1d023-dc64-4a99-a91f-a2d201b3bef1"), "Migdam Adil Yousif", "0928077666", "Esoteric" },
                    { new Guid("f3941283-8b99-42df-b4d8-86eb70eb5cc4"), "Mogtaba Saifaldeen Mohammed", "0928077888", "General" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "FullName", "Gender", "UserName" },
                values: new object[,]
                {
                    { new Guid("41670381-5207-43e3-9596-9f122027a236"), "Waleed Mohanned Hassan", "Male", "Waleed" },
                    { new Guid("4d350a45-21c2-475c-8a4d-cd1463fa8c13"), "Mujab Nasraldeen Othman", "Male", "Mujab" },
                    { new Guid("541b3472-3953-493b-a62b-1fba107ef635"), "Duaa Nasraldeen Othman", "Female", "Duaa" },
                    { new Guid("9f3063e2-e89f-4c26-a4be-f6557a0e0d7b"), "Ahmed Aziz Abas", "Male", "Ahmed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointments_AppointmentId",
                table: "PatientAppointments",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointments_DoctorId",
                table: "PatientAppointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAppointments_PatientId",
                table: "PatientAppointments",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointments_Appointments_AppointmentId",
                table: "PatientAppointments",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointments_Doctors_DoctorId",
                table: "PatientAppointments",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAppointments_Patients_PatientId",
                table: "PatientAppointments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointments_Appointments_AppointmentId",
                table: "PatientAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointments_Doctors_DoctorId",
                table: "PatientAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAppointments_Patients_PatientId",
                table: "PatientAppointments");

            migrationBuilder.DropIndex(
                name: "IX_PatientAppointments_AppointmentId",
                table: "PatientAppointments");

            migrationBuilder.DropIndex(
                name: "IX_PatientAppointments_DoctorId",
                table: "PatientAppointments");

            migrationBuilder.DropIndex(
                name: "IX_PatientAppointments_PatientId",
                table: "PatientAppointments");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("daa1d023-dc64-4a99-a91f-a2d201b3bef1"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f3941283-8b99-42df-b4d8-86eb70eb5cc4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("41670381-5207-43e3-9596-9f122027a236"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4d350a45-21c2-475c-8a4d-cd1463fa8c13"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("541b3472-3953-493b-a62b-1fba107ef635"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("9f3063e2-e89f-4c26-a4be-f6557a0e0d7b"));

            migrationBuilder.AddColumn<Guid>(
                name: "PatientAppointmentId",
                table: "Patients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PatientAppointmentId",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PatientAppointmentId",
                table: "Appointments",
                type: "uniqueidentifier",
                nullable: true);

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
                name: "IX_Patients_PatientAppointmentId",
                table: "Patients",
                column: "PatientAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_PatientAppointmentId",
                table: "Doctors",
                column: "PatientAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientAppointmentId",
                table: "Appointments",
                column: "PatientAppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_PatientAppointments_PatientAppointmentId",
                table: "Appointments",
                column: "PatientAppointmentId",
                principalTable: "PatientAppointments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_PatientAppointments_PatientAppointmentId",
                table: "Doctors",
                column: "PatientAppointmentId",
                principalTable: "PatientAppointments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_PatientAppointments_PatientAppointmentId",
                table: "Patients",
                column: "PatientAppointmentId",
                principalTable: "PatientAppointments",
                principalColumn: "Id");
        }
    }
}
