using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace runlog2021api.Migrations
{
    public partial class runlog2021apiModelsRunContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Length",
                table: "Runs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Runs",
                columns: new[] { "RunId", "Date", "Duration", "Length" },
                values: new object[] { 1L, new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 44, 46, 0), 6.6200000000000001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Runs",
                keyColumn: "RunId",
                keyValue: 1L);

            migrationBuilder.AlterColumn<int>(
                name: "Length",
                table: "Runs",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
