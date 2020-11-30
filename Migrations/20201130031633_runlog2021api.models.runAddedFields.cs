using Microsoft.EntityFrameworkCore.Migrations;

namespace runlog2021api.Migrations
{
    public partial class runlog2021apimodelsrunAddedFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RunListenedTo",
                table: "Runs",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SleepHours",
                table: "Runs",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SleepToBedTime",
                table: "Runs",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SleepWakeTime",
                table: "Runs",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Temperature",
                table: "Runs",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RunListenedTo",
                table: "Runs");

            migrationBuilder.DropColumn(
                name: "SleepHours",
                table: "Runs");

            migrationBuilder.DropColumn(
                name: "SleepToBedTime",
                table: "Runs");

            migrationBuilder.DropColumn(
                name: "SleepWakeTime",
                table: "Runs");

            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "Runs");
        }
    }
}
