using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations.OdinDBContentMigrations
{
    public partial class d603 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefaultQueueProcesses_Process_processChildid",
                table: "DefaultQueueProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_MachineProcessChild_Process_ProcessChildrenListid",
                table: "MachineProcessChild");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_Process_processIdid",
                table: "Process");

            migrationBuilder.DropForeignKey(
                name: "FK_QueueProcesses_Process_processChildIdid",
                table: "QueueProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_QueueProcessLog_Process_restartableProcessid",
                table: "QueueProcessLog");

            migrationBuilder.DropForeignKey(
                name: "FK_SchedulerProcess_Process_processChildIdid",
                table: "SchedulerProcess");

            migrationBuilder.DropIndex(
                name: "IX_Process_processIdid",
                table: "Process");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Process");

            migrationBuilder.DropColumn(
                name: "maxCountMachines",
                table: "Process");

            migrationBuilder.DropColumn(
                name: "minCountMachines",
                table: "Process");

            migrationBuilder.DropColumn(
                name: "priority",
                table: "Process");

            migrationBuilder.DropColumn(
                name: "processIdid",
                table: "Process");

            migrationBuilder.DropColumn(
                name: "startParams",
                table: "Process");

            migrationBuilder.CreateTable(
                name: "ProcessChild",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    processIdid = table.Column<int>(type: "int", nullable: true),
                    startParams = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    priority = table.Column<int>(type: "int", nullable: false),
                    maxCountMachines = table.Column<int>(type: "int", nullable: false),
                    minCountMachines = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessChild", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProcessChild_Process_processIdid",
                        column: x => x.processIdid,
                        principalTable: "Process",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProcessChild_processIdid",
                table: "ProcessChild",
                column: "processIdid");

            migrationBuilder.AddForeignKey(
                name: "FK_DefaultQueueProcesses_ProcessChild_processChildid",
                table: "DefaultQueueProcesses",
                column: "processChildid",
                principalTable: "ProcessChild",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineProcessChild_ProcessChild_ProcessChildrenListid",
                table: "MachineProcessChild",
                column: "ProcessChildrenListid",
                principalTable: "ProcessChild",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QueueProcesses_ProcessChild_processChildIdid",
                table: "QueueProcesses",
                column: "processChildIdid",
                principalTable: "ProcessChild",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QueueProcessLog_ProcessChild_restartableProcessid",
                table: "QueueProcessLog",
                column: "restartableProcessid",
                principalTable: "ProcessChild",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SchedulerProcess_ProcessChild_processChildIdid",
                table: "SchedulerProcess",
                column: "processChildIdid",
                principalTable: "ProcessChild",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefaultQueueProcesses_ProcessChild_processChildid",
                table: "DefaultQueueProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_MachineProcessChild_ProcessChild_ProcessChildrenListid",
                table: "MachineProcessChild");

            migrationBuilder.DropForeignKey(
                name: "FK_QueueProcesses_ProcessChild_processChildIdid",
                table: "QueueProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_QueueProcessLog_ProcessChild_restartableProcessid",
                table: "QueueProcessLog");

            migrationBuilder.DropForeignKey(
                name: "FK_SchedulerProcess_ProcessChild_processChildIdid",
                table: "SchedulerProcess");

            migrationBuilder.DropTable(
                name: "ProcessChild");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Process",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "maxCountMachines",
                table: "Process",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "minCountMachines",
                table: "Process",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "priority",
                table: "Process",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "processIdid",
                table: "Process",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "startParams",
                table: "Process",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Process_processIdid",
                table: "Process",
                column: "processIdid");

            migrationBuilder.AddForeignKey(
                name: "FK_DefaultQueueProcesses_Process_processChildid",
                table: "DefaultQueueProcesses",
                column: "processChildid",
                principalTable: "Process",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineProcessChild_Process_ProcessChildrenListid",
                table: "MachineProcessChild",
                column: "ProcessChildrenListid",
                principalTable: "Process",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_Process_processIdid",
                table: "Process",
                column: "processIdid",
                principalTable: "Process",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QueueProcesses_Process_processChildIdid",
                table: "QueueProcesses",
                column: "processChildIdid",
                principalTable: "Process",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QueueProcessLog_Process_restartableProcessid",
                table: "QueueProcessLog",
                column: "restartableProcessid",
                principalTable: "Process",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SchedulerProcess_Process_processChildIdid",
                table: "SchedulerProcess",
                column: "processChildIdid",
                principalTable: "Process",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
