using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations
{
    public partial class w1 : Migration
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
                    DESC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessPermissions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AccessRole",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ROLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessRole", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AccessUsers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAIL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessUsers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "QueueItemIDs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KEY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERROR1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERROR2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TECH_ERROR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_FILE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_COMMENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_DOC_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_START_WORK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_END_WORK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_INTEGRATION_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_PAY_CONDITIONS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_ATTORNEY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_REF_TAB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_PSDC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_DOP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_DOP_N = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_SUMM_WO_NDS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIR_DIAP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DS_N = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DS_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOG_N = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTRACT_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GFK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TASK_LIST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTRACT_N = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROVIDER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROVIDER_INN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZM_N = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZM_LOT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZM_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIRECTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FILIAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GEO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPANY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRI_CODE_PROJECT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRI_REF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRI_BS_N = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRI_BS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRI_KT_CMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRI_DOUBLE_OF_PROJECT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PR_N = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PR_FILE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PR_STATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INITIATOR_FIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INITIATOR_MAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RESPONSIBLE_FIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RESPONSIBLE_MAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIADOK_REF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIADOK_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIADOK_FILE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIADOK_UPLOAD_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIADOK_SIGN_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REQUIRED_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EXPECTED_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEVD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEVD_N = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TAX_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P2P = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ECM_REF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMS_LINK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VENDOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRI_CODE_PROJECT_LIST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RESPONSIBLE_CHOISE_REASON = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueueItemIDs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AccessRolePermissions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACCESSROLEid = table.Column<int>(type: "int", nullable: true),
                    ACCESSPERMISSIONSid = table.Column<int>(type: "int", nullable: true)
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
                    ACCESSUSERSid = table.Column<int>(type: "int", nullable: true),
                    ACCESSROLEid = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Cess76Ints",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RESPONSIBLE_FOR_CHOICE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHOICE_STATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHOICE_DATETIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QUEUEITEMID_REF = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cess76Ints", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cess76Ints_QueueItemIDs_QUEUEITEMID_REF",
                        column: x => x.QUEUEITEMID_REF,
                        principalTable: "QueueItemIDs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_Cess76Ints_QUEUEITEMID_REF",
                table: "Cess76Ints",
                column: "QUEUEITEMID_REF",
                unique: true);
            //Cess76
            migrationBuilder.Sql("IF EXISTS( SELECT * FROM sys.triggers WHERE name='Cess76Int_DEL')" +
                " DROP TRIGGER Cess76Int_DEL");

            migrationBuilder.Sql("CREATE TRIGGER Cess76Int_DEL ON QueueItemIDs FOR DELETE AS " +
                "BEGIN " +
                "IF @@ROWCOUNT = 0 " +
                "   RETURN " +
                "SET NOCOUNT ON " +
                "DECLARE @QID VARCHAR(50) " +
                "SELECT @QID = (SELECT QID FROM DELETED) " +
                "DELETE Cess76Ints " +
                "WHERE QID = @QID " +
                "END");

            migrationBuilder.Sql("IF EXISTS( SELECT * FROM sys.triggers WHERE name='Cess76Int_ADD') " +
                "DROP TRIGGER Cess76Int_ADD");

            migrationBuilder.Sql("CREATE TRIGGER Cess76Int_ADD  " +
                "ON QueueItemIDs " +
                "FOR INSERT " +
                "AS " +
                "BEGIN " +
                "IF @@ROWCOUNT = 0 " +
                "   RETURN " +
                "SET NOCOUNT ON " +
                "DECLARE @QID VARCHAR(50) " +
                "DECLARE @sID INT " +
                "SELECT @QID = (SELECT QID FROM INSERTED) " +
                "SELECT @sID = (SELECT id FROM INSERTED) " +
                "INSERT Cess76Ints(QID, STATUS, QUEUEITEMID_REF, CHOICE_DATETIME) " +
                "VALUES(@QID, 'NEW', @sID, GETDATE()) " +
                "END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessRolePermissions");

            migrationBuilder.DropTable(
                name: "AccessUserRole");

            migrationBuilder.DropTable(
                name: "Cess76Ints");

            migrationBuilder.DropTable(
                name: "AccessPermissions");

            migrationBuilder.DropTable(
                name: "AccessRole");

            migrationBuilder.DropTable(
                name: "AccessUsers");

            migrationBuilder.DropTable(
                name: "QueueItemIDs");
        }
    }
}
