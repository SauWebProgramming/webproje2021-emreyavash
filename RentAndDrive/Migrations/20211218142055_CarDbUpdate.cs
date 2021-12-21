using Microsoft.EntityFrameworkCore.Migrations;

namespace RentAndDrive.Migrations
{
    public partial class CarDbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vites",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yakit",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vites",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Yakit",
                table: "Cars");
        }
    }
}
