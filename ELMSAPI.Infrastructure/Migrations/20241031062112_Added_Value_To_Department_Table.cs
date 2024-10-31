using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELMSAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_Value_To_Department_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "Status" },
                values: new object[] { 1, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Office of the Minister", "I" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
