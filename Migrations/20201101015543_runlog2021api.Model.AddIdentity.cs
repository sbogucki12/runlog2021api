﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace runlog2021api.Migrations
{
    public partial class runlog2021apiModelAddIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Runs",
                keyColumn: "RunId",
                keyValue: 1L);

            migrationBuilder.AlterColumn<int>(
                name: "RunId",
                table: "Runs",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Runs",
                columns: new[] { "RunId", "Date", "Duration", "ImageUrl", "Length", "Pace", "Surface", "Type" },
                values: new object[] { 1, new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 44, 46, 0), null, 6.6200000000000001, new TimeSpan(4057401813), "beach", "Not a valid Run Type." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Runs",
                keyColumn: "RunId",
                keyValue: 1);

            migrationBuilder.AlterColumn<long>(
                name: "RunId",
                table: "Runs",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Runs",
                columns: new[] { "RunId", "Date", "Duration", "ImageUrl", "Length", "Pace", "Surface", "Type" },
                values: new object[] { 1L, new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 44, 46, 0), null, 6.6200000000000001, new TimeSpan(4057401813), "beach", "Not a valid Run Type." });
        }
    }
}
