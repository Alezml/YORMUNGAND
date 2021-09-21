using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations.CESSDBContentMigrations
{
    public partial class d612 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatCessReportDwnld");

            migrationBuilder.AddColumn<DateTime>(
                name: "LAST_UPDATE",
                table: "MAIN-1",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LAST_UPDATE",
                table: "MAIN-1");

            migrationBuilder.CreateTable(
                name: "StatCessReportDwnld",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EVENT_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ROWS_COUNT = table.Column<int>(type: "int", nullable: false),
                    USER = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatCessReportDwnld", x => x.id);
                });
        }
    }
}
