using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace runlog2021api.Migrations
{
    public partial class runlog2021apiModelsContextSeed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Runs",
                columns: new[] { "RunId", "Date", "Duration", "Length", "Pace" },
                values: new object[] { 2L, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 37, 21, 0), 5.3399999999999999, new TimeSpan(4196629213) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Runs",
                keyColumn: "RunId",
                keyValue: 2L);
        }
    }
}
