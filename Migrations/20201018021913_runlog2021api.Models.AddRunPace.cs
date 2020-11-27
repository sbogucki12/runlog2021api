using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace runlog2021api.Migrations
{
    public partial class runlog2021apiModelsAddRunPace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Pace",
                table: "Runs",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Runs",
                keyColumn: "RunId",
                keyValue: 1L,
                column: "Pace",
                value: new TimeSpan(4057401813));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pace",
                table: "Runs");
        }
    }
}
