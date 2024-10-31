using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ELMSAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_All_Department_Table_Values : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "Status" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Office of Secretary of State ", "I" },
                    { 3, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accounts", "I" },
                    { 4, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asset Management Unit", "I" },
                    { 5, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debt Management Unit", "I" },
                    { 6, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procurement Oversight Unity (POU)", "I" },
                    { 7, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Macro-Economic Forecasting Analyst Branch (MFAB)", "I" },
                    { 8, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "I" },
                    { 9, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administration", "I" },
                    { 10, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "System Support", "I" },
                    { 11, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Planning and Control", "I" },
                    { 12, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public Investment Management", "I" },
                    { 13, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public Budget Management", "I" },
                    { 14, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public Accounts Management", "I" },
                    { 15, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Treasury", "I" },
                    { 16, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tax & Sectorial Policy", "I" },
                    { 17, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Services Development", "I" },
                    { 18, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internal Audit", "I" },
                    { 19, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trade", "I" },
                    { 20, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "National Planning", "I" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
