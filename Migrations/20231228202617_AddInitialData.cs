using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Veterinarians",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AnimalPassports",
                columns: new[] { "Id", "Age", "Breed", "Gender", "Name" },
                values: new object[] { 1, 11, "SomeBreed", "Male", "A Dog" });

            migrationBuilder.InsertData(
                table: "VaccineRegistries",
                columns: new[] { "Id", "ExpiryDate", "SerialNumber", "VaccineName" },
                values: new object[] { 1, new DateTime(2024, 12, 28, 20, 26, 16, 672, DateTimeKind.Utc).AddTicks(1584), "12345", "Vaccine1" });

            migrationBuilder.InsertData(
                table: "Veterinarians",
                columns: new[] { "Id", "FirstName", "LastName", "SocialNumber" },
                values: new object[] { 1, "Luke", "Vader", "12345" });

            migrationBuilder.InsertData(
                table: "Vaccinations",
                columns: new[] { "Id", "AnimalPassportId", "Date", "VaccineId", "VeterinarianId" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 28, 20, 26, 16, 672, DateTimeKind.Utc).AddTicks(1615), 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnimalPassports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VaccineRegistries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "Veterinarians",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
