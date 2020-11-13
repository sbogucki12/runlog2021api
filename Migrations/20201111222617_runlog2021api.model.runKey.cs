using Microsoft.EntityFrameworkCore.Migrations;

namespace runlog2021api.Migrations
{
    public partial class runlog2021apimodelrunKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "Runs");

            migrationBuilder.AddColumn<int>(
                name: "RunKey",
                table: "Runs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RunKey",
                table: "Runs");

            migrationBuilder.AddColumn<int>(
                name: "Key",
                table: "Runs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
