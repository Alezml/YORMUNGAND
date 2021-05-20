using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YORMUNGAND.Migrations.CESSDBContentMigrations
{
    public partial class d005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MAIN-1",
                columns: table => new
                {
                    Ключсчетчик = table.Column<int>(name: "Ключ (счетчик)", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NRI_ссылка = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ЗМ_с_лотом = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Регион = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Филиал = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRI_БС_Номер = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRI_БС_Наименование = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ДС_Номер = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Поставщик = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ВИР_Тип_документа = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ВИР_Дополнение = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ВИР_Дополнение_номер = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ВИР_дата = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ВИР_Сумма_без_НДС = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ВИР_Условия_платежа = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Инициатор_ФИО = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ответственный_ФИО = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Этап = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PR_Номер = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PR_статус = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PR_Комментарий = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    СЭВД = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    СЭВД_Номер = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ЕСМ_ссылка = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ДС_Дата = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ГФК = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ВИР_Начало_работ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ВИР_Завершение_работ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ВИР_Дата_интеграции = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Диадок_Дата_загрузки = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Диадок_Дата_подписания = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMS_ссылка = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Диадок_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Диадок_ссылка = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRI_Код_проекта = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Контракт_номер = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Договор_номер = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Договор_дата = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Инициатор_почта = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Поставщик_ИНН = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ошибка1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ошибка2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Тех_Ошибка = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Обработка = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    География = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ЗП_Номер = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ЗП_Статус = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    БД_комментарий = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PR_файл = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ВИР_комментарий = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Дубль = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ВИР_Диапазоны = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Проставление = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Дозаполнение_ЕСМ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAIN-1", x => x.Ключсчетчик);
                });

            migrationBuilder.CreateTable(
                name: "StatCessReportDwnld",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROWS_COUNT = table.Column<int>(type: "int", nullable: false),
                    EVENT_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatCessReportDwnld", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TEST",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEST", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MAIN-1");

            migrationBuilder.DropTable(
                name: "StatCessReportDwnld");

            migrationBuilder.DropTable(
                name: "TEST");
        }
    }
}
