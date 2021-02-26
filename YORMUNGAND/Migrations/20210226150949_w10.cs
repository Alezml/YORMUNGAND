using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations
{
    public partial class w10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessPermissions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PERMISSION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACCESSROLE_REF = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessPermissions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AccessUserRole",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACCESSUSERS_REF = table.Column<int>(type: "int", nullable: false),
                    ACCESSROLE_REF = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessUserRole", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AccessRole",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ROLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACCESSUSERROLEid = table.Column<int>(type: "int", nullable: true),
                    ACCESSPERMISSIONSid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessRole", x => x.id);
                    table.ForeignKey(
                        name: "FK_AccessRole_AccessPermissions_ACCESSPERMISSIONSid",
                        column: x => x.ACCESSPERMISSIONSid,
                        principalTable: "AccessPermissions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccessRole_AccessUserRole_ACCESSUSERROLEid",
                        column: x => x.ACCESSUSERROLEid,
                        principalTable: "AccessUserRole",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccessUsers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACCESSUSERROLEid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessUsers", x => x.id);
                    table.ForeignKey(
                        name: "FK_AccessUsers_AccessUserRole_ACCESSUSERROLEid",
                        column: x => x.ACCESSUSERROLEid,
                        principalTable: "AccessUserRole",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessRole_ACCESSPERMISSIONSid",
                table: "AccessRole",
                column: "ACCESSPERMISSIONSid");

            migrationBuilder.CreateIndex(
                name: "IX_AccessRole_ACCESSUSERROLEid",
                table: "AccessRole",
                column: "ACCESSUSERROLEid");

            migrationBuilder.CreateIndex(
                name: "IX_AccessUsers_ACCESSUSERROLEid",
                table: "AccessUsers",
                column: "ACCESSUSERROLEid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessRole");

            migrationBuilder.DropTable(
                name: "AccessUsers");

            migrationBuilder.DropTable(
                name: "AccessPermissions");

            migrationBuilder.DropTable(
                name: "AccessUserRole");
        }
    }
}
