using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations
{
    public partial class d42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RPAAlert",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROCES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TAG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERROR_MSG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EVENT_TIME = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPAAlert", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RPAAlert");
        }
    }
}
