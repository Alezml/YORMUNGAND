using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations.OdinDBContentMigrations
{
    public partial class d601 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    machineName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Process",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responsible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    processIdid = table.Column<int>(type: "int", nullable: true),
                    startParams = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    priority = table.Column<int>(type: "int", nullable: true),
                    maxCountMachines = table.Column<int>(type: "int", nullable: true),
                    minCountMachines = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process", x => x.id);
                    table.ForeignKey(
                        name: "FK_Process_Process_processIdid",
                        column: x => x.processIdid,
                        principalTable: "Process",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DefaultQueueProcesses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeOfSchedule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paramDay = table.Column<int>(type: "int", nullable: false),
                    timeSpanStart = table.Column<TimeSpan>(type: "time", nullable: false),
                    processChildid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultQueueProcesses", x => x.id);
                    table.ForeignKey(
                        name: "FK_DefaultQueueProcesses_Process_processChildid",
                        column: x => x.processChildid,
                        principalTable: "Process",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MachineProcessChild",
                columns: table => new
                {
                    ProcessChildrenListid = table.Column<int>(type: "int", nullable: false),
                    machineListid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineProcessChild", x => new { x.ProcessChildrenListid, x.machineListid });
                    table.ForeignKey(
                        name: "FK_MachineProcessChild_Machine_machineListid",
                        column: x => x.machineListid,
                        principalTable: "Machine",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineProcessChild_Process_ProcessChildrenListid",
                        column: x => x.ProcessChildrenListid,
                        principalTable: "Process",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QueueProcesses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    processChildIdid = table.Column<int>(type: "int", nullable: true),
                    needStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    priority = table.Column<int>(type: "int", nullable: false),
                    isWorked = table.Column<bool>(type: "bit", nullable: false),
                    minCountMachines = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueueProcesses", x => x.id);
                    table.ForeignKey(
                        name: "FK_QueueProcesses_Process_processChildIdid",
                        column: x => x.processChildIdid,
                        principalTable: "Process",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchedulerProcess",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    processChildIdid = table.Column<int>(type: "int", nullable: true),
                    timeStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchedulerProcess", x => x.id);
                    table.ForeignKey(
                        name: "FK_SchedulerProcess_Process_processChildIdid",
                        column: x => x.processChildIdid,
                        principalTable: "Process",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QueueProcessLog",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartRequestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartProcessTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndProcessTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Machineid = table.Column<int>(type: "int", nullable: true),
                    isSuccess = table.Column<bool>(type: "bit", nullable: false),
                    needRestart = table.Column<bool>(type: "bit", nullable: false),
                    restartableProcessid = table.Column<int>(type: "int", nullable: true),
                    QueueProcessesid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueueProcessLog", x => x.id);
                    table.ForeignKey(
                        name: "FK_QueueProcessLog_Machine_Machineid",
                        column: x => x.Machineid,
                        principalTable: "Machine",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueueProcessLog_Process_restartableProcessid",
                        column: x => x.restartableProcessid,
                        principalTable: "Process",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueueProcessLog_QueueProcesses_QueueProcessesid",
                        column: x => x.QueueProcessesid,
                        principalTable: "QueueProcesses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DefaultQueueProcesses_processChildid",
                table: "DefaultQueueProcesses",
                column: "processChildid");

            migrationBuilder.CreateIndex(
                name: "IX_MachineProcessChild_machineListid",
                table: "MachineProcessChild",
                column: "machineListid");

            migrationBuilder.CreateIndex(
                name: "IX_Process_processIdid",
                table: "Process",
                column: "processIdid");

            migrationBuilder.CreateIndex(
                name: "IX_QueueProcesses_processChildIdid",
                table: "QueueProcesses",
                column: "processChildIdid");

            migrationBuilder.CreateIndex(
                name: "IX_QueueProcessLog_Machineid",
                table: "QueueProcessLog",
                column: "Machineid");

            migrationBuilder.CreateIndex(
                name: "IX_QueueProcessLog_QueueProcessesid",
                table: "QueueProcessLog",
                column: "QueueProcessesid");

            migrationBuilder.CreateIndex(
                name: "IX_QueueProcessLog_restartableProcessid",
                table: "QueueProcessLog",
                column: "restartableProcessid");

            migrationBuilder.CreateIndex(
                name: "IX_SchedulerProcess_processChildIdid",
                table: "SchedulerProcess",
                column: "processChildIdid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefaultQueueProcesses");

            migrationBuilder.DropTable(
                name: "MachineProcessChild");

            migrationBuilder.DropTable(
                name: "QueueProcessLog");

            migrationBuilder.DropTable(
                name: "SchedulerProcess");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "QueueProcesses");

            migrationBuilder.DropTable(
                name: "Process");
        }
    }
}
