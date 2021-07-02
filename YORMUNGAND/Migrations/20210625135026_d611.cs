using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations
{
    public partial class d611 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LINK",
                table: "VBAproject",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "VER",
                table: "VBAproject",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CompName",
                table: "VBAlog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "VER",
                table: "VBAlog",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LINK",
                table: "VBAproject");

            migrationBuilder.DropColumn(
                name: "VER",
                table: "VBAproject");

            migrationBuilder.DropColumn(
                name: "CompName",
                table: "VBAlog");

            migrationBuilder.DropColumn(
                name: "VER",
                table: "VBAlog");
        }
    }
}
