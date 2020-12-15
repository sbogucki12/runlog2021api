using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace runlog2021api.Migrations
{
    public partial class runlog2021apisleepdatatypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SleepWakeTime",
                table: "Runs",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SleepToBedTime",
                table: "Runs",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoeAge",
                table: "Runs");

            migrationBuilder.AlterColumn<double>(
                name: "SleepWakeTime",
                table: "Runs",
                type: "float",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<double>(
                name: "SleepToBedTime",
                table: "Runs",
                type: "float",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
