using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations
{
    public partial class w6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KEY",
                table: "QueueItemIDs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KEY",
                table: "QueueItemIDs");
        }
    }
}
