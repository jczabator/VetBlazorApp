using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToVaccineRegistryId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaccinations_VaccineRegistries_VaccineId",
                table: "Vaccinations");

            migrationBuilder.RenameColumn(
                name: "VaccineId",
                table: "Vaccinations",
                newName: "VaccineRegistryId");

            migrationBuilder.RenameIndex(
                name: "IX_Vaccinations_VaccineId",
                table: "Vaccinations",
                newName: "IX_Vaccinations_VaccineRegistryId");

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 12, 28, 22, 29, 49, 732, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "VaccineRegistries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDate",
                value: new DateTime(2024, 12, 28, 22, 29, 49, 732, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccinations_VaccineRegistries_VaccineRegistryId",
                table: "Vaccinations",
                column: "VaccineRegistryId",
                principalTable: "VaccineRegistries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaccinations_VaccineRegistries_VaccineRegistryId",
                table: "Vaccinations");

            migrationBuilder.RenameColumn(
                name: "VaccineRegistryId",
                table: "Vaccinations",
                newName: "VaccineId");

            migrationBuilder.RenameIndex(
                name: "IX_Vaccinations_VaccineRegistryId",
                table: "Vaccinations",
                newName: "IX_Vaccinations_VaccineId");

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 12, 28, 20, 26, 16, 672, DateTimeKind.Utc).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "VaccineRegistries",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDate",
                value: new DateTime(2024, 12, 28, 20, 26, 16, 672, DateTimeKind.Utc).AddTicks(1584));

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccinations_VaccineRegistries_VaccineId",
                table: "Vaccinations",
                column: "VaccineId",
                principalTable: "VaccineRegistries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
