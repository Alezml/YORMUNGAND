using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations
{
    public partial class d491 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CESSVIRCOMMENTS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CESSVIRCOMMENTS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AUTHOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMMENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENABLE = table.Column<bool>(type: "bit", nullable: false),
                    END_TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SQL_STRING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    START_TIME = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CESSVIRCOMMENTS", x => x.id);
                });
        }
    }
}
