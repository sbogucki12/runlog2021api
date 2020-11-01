﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace runlog2021api.Migrations
{
    public partial class runlog2021apiModelsContextRemoveRuns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Runs",
                keyColumn: "RunId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Runs",
                keyColumn: "RunId",
                keyValue: 2L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Runs",
                columns: new[] { "RunId", "Date", "Duration", "ImageUrl", "Length", "Pace", "Surface", "Type" },
                values: new object[] { 1L, new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 44, 46, 0), null, 6.6200000000000001, new TimeSpan(4057401813), null, null });

            migrationBuilder.InsertData(
                table: "Runs",
                columns: new[] { "RunId", "Date", "Duration", "ImageUrl", "Length", "Pace", "Surface", "Type" },
                values: new object[] { 2L, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 37, 21, 0), null, 5.3399999999999999, new TimeSpan(4196629213), null, null });
        }
    }
}