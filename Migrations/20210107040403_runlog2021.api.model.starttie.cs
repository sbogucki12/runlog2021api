using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace runlog2021api.Migrations
{
    public partial class runlog2021apimodelstarttie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Runs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Runs");
        }
    }
}
