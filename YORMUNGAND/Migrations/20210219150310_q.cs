using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations
{
    public partial class q : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QueueItemID",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QID = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_QueueItemID", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QueueItemID");
        }
    }
}
