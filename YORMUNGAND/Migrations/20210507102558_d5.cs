using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations
{
    public partial class d5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "COUNT",
                table: "RPAAlert",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "COUNT",
                table: "RPAAlert");
        }
    }
}
