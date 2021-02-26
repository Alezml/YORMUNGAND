using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;

namespace YORMUNGAND.Migrations
{
    public partial class w7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("IF EXISTS( SELECT * FROM sys.triggers WHERE name='Cess76Int_DEL')DROP TRIGGER Cess76Int_DEL");
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
