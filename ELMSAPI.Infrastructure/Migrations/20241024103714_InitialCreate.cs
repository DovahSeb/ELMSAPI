using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ELMSAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LeaveStatuses",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4531), new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4544), "Pending", "I" },
                    { 2, new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4546), new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4546), "Approved", "I" },
                    { 3, new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4547), new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4548), "Rejected", "I" }
                });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "DateCreated", "DateModified", "Status", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4648), new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4650), "I", "Annual" },
                    { 2, new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4651), new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4652), "I", "Sick" },
                    { 3, new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4653), new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4653), "I", "Maternity" },
                    { 4, new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4654), new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4654), "I", "Paternity" },
                    { 5, new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 10, 24, 14, 37, 14, 92, DateTimeKind.Local).AddTicks(4656), "I", "Unpaid" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveStatuses");

            migrationBuilder.DropTable(
                name: "LeaveTypes");
        }
    }
}
