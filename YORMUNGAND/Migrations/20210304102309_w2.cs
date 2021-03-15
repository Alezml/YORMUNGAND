using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations
{
    public partial class w2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessRolePermissions");

            migrationBuilder.DropTable(
                name: "AccessUserRole");

            migrationBuilder.CreateTable(
                name: "AccessPermissionsAccessRole",
                columns: table => new
                {
                    ACCESSPERMISSIONSid = table.Column<int>(type: "int", nullable: false),
                    ACCESSROLEid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessPermissionsAccessRole", x => new { x.ACCESSPERMISSIONSid, x.ACCESSROLEid });
                    table.ForeignKey(
                        name: "FK_AccessPermissionsAccessRole_AccessPermissions_ACCESSPERMISSIONSid",
                        column: x => x.ACCESSPERMISSIONSid,
                        principalTable: "AccessPermissions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccessPermissionsAccessRole_AccessRole_ACCESSROLEid",
                        column: x => x.ACCESSROLEid,
                        principalTable: "AccessRole",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccessRoleAccessUsers",
                columns: table => new
                {
                    ACCESSROLEid = table.Column<int>(type: "int", nullable: false),
                    ACCESSUSERSid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessRoleAccessUsers", x => new { x.ACCESSROLEid, x.ACCESSUSERSid });
                    table.ForeignKey(
                        name: "FK_AccessRoleAccessUsers_AccessRole_ACCESSROLEid",
                        column: x => x.ACCESSROLEid,
                        principalTable: "AccessRole",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccessRoleAccessUsers_AccessUsers_ACCESSUSERSid",
                        column: x => x.ACCESSUSERSid,
                        principalTable: "AccessUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessPermissionsAccessRole_ACCESSROLEid",
                table: "AccessPermissionsAccessRole",
                column: "ACCESSROLEid");

            migrationBuilder.CreateIndex(
                name: "IX_AccessRoleAccessUsers_ACCESSUSERSid",
                table: "AccessRoleAccessUsers",
                column: "ACCESSUSERSid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessPermissionsAccessRole");

            migrationBuilder.DropTable(
                name: "AccessRoleAccessUsers");

            migrationBuilder.CreateTable(
                name: "AccessRolePermissions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACCESSPERMISSIONSid = table.Column<int>(type: "int", nullable: true),
                    ACCESSROLEid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessRolePermissions", x => x.id);
                    table.ForeignKey(
                        name: "FK_AccessRolePermissions_AccessPermissions_ACCESSPERMISSIONSid",
                        column: x => x.ACCESSPERMISSIONSid,
                        principalTable: "AccessPermissions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccessRolePermissions_AccessRole_ACCESSROLEid",
                        column: x => x.ACCESSROLEid,
                        principalTable: "AccessRole",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccessUserRole",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACCESSROLEid = table.Column<int>(type: "int", nullable: true),
                    ACCESSUSERSid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessUserRole", x => x.id);
                    table.ForeignKey(
                        name: "FK_AccessUserRole_AccessRole_ACCESSROLEid",
                        column: x => x.ACCESSROLEid,
                        principalTable: "AccessRole",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccessUserRole_AccessUsers_ACCESSUSERSid",
                        column: x => x.ACCESSUSERSid,
                        principalTable: "AccessUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessRolePermissions_ACCESSPERMISSIONSid",
                table: "AccessRolePermissions",
                column: "ACCESSPERMISSIONSid");

            migrationBuilder.CreateIndex(
                name: "IX_AccessRolePermissions_ACCESSROLEid",
                table: "AccessRolePermissions",
                column: "ACCESSROLEid");

            migrationBuilder.CreateIndex(
                name: "IX_AccessUserRole_ACCESSROLEid",
                table: "AccessUserRole",
                column: "ACCESSROLEid");

            migrationBuilder.CreateIndex(
                name: "IX_AccessUserRole_ACCESSUSERSid",
                table: "AccessUserRole",
                column: "ACCESSUSERSid");
        }
    }
}
