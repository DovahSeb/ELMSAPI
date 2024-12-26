using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELMSAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Updated_LeaveAllowance_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysTaken",
                table: "LeaveAllowances");

            migrationBuilder.RenameColumn(
                name: "TotalLeaveDays",
                table: "LeaveAllowances",
                newName: "TotalLeaveAllowance");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalLeaveAllowance",
                table: "LeaveAllowances",
                newName: "TotalLeaveDays");

            migrationBuilder.AddColumn<float>(
                name: "DaysTaken",
                table: "LeaveAllowances",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
