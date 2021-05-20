using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;
using YORMUNGAND.Data.Repository;

namespace YORMUNGAND.Controllers
{
    public class CessReportController : Controller
    {
        private readonly CESSDBContent _cessDBContent;
        private readonly AppDBContent _appDBContent;
        private CessReportRepository _rep;
        protected static IServiceProvider _service;
        public CessReportController(CESSDBContent cessDBContent, IServiceProvider service, AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
            _cessDBContent = cessDBContent;
            _rep = new CessReportRepository(_cessDBContent, _appDBContent);
            _service = service;
        }
        //[Route("CESS/REPORTS/WAVE1/{page:int?}")]
        [Route("CESS/REPORTS/WAVE1")]
        public IActionResult List1()
        {
            switch (Access.IsAccess(_service, "P_CESS_READER"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            MainReportWave1FS SerchParam = new MainReportWave1FS();
            //var s = new CessReportRepository(_appDBContent);
            SerchParam.data = _rep.MainReportWave1ss(SerchParam);
            SerchParam.count = _rep.MainReportWave1c(SerchParam);
            SerchParam.countTotal = _rep.MainReportWave1ct(SerchParam);
            //SerchParam.data = _rep.MainReportWave1post(SerchParam.data);
            SerchParam.REGIONSELECT = _rep.GetSelectList("REGION", "Все регионы");
            ViewBag.Title = "ОТЧЕТ ЦЭСС ПЕРВАЯ ВОЛНА";
            return View(SerchParam);
        }

        [HttpPost]
        [Route("CESS/REPORTS/WAVE1")]
        public IActionResult List1(MainReportWave1FS SerchParam)
        {
            switch (Access.IsAccess(_service, "P_CESS_READER"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            SerchParam = MainReportWave1FS.Check(SerchParam);
            SerchParam.data = _rep.MainReportWave1ss(SerchParam);
            SerchParam.count = _rep.MainReportWave1c(SerchParam);
            SerchParam.countTotal = _rep.MainReportWave1ct(SerchParam);
            //SerchParam.data = _rep.MainReportWave1post(SerchParam.data);
            SerchParam.REGIONSELECT = _rep.GetSelectList("REGION", "Все регионы");
            ViewBag.Title = "Поиск ОТЧЕТ ЦЭСС ПЕРВАЯ ВОЛНА";
            return View(SerchParam);
        }
        public IActionResult Detail1stWave(int ID)
        {
            switch (Access.IsAccess(_service, "P_CESS_READER"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            MainReportWave1 One1stWave = new MainReportWave1();
            One1stWave = _rep.Detail1stWaveById(ID);
            //return View(One1stWave);
            return Content("В разработке");
        }

        public ActionResult Export(MainReportWave1FS SerchParam)
        {
            switch (Access.IsAccess(_service, "P_CESS_READER"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            MainReportWave1FS _sp = SerchParam;
            _sp.data = null;
            IEnumerable<MainReportWave1> _data = _rep.MainReportWave1Exports(_sp);
            _rep.AddStatisticCessReprtDwld(Access.GetUserName(_service), _data.ToList().Count); //статистика
            if (_data.ToList().Count == 0)
            {
                ViewData["NoExport"] = "Yes";
                SerchParam = MainReportWave1FS.Check(SerchParam);
                SerchParam.data = _rep.MainReportWave1ss(SerchParam);
                SerchParam.count = _rep.MainReportWave1c(SerchParam);
                SerchParam.countTotal = _rep.MainReportWave1ct(SerchParam);
                return View("List1", SerchParam);

                //return RedirectToAction("List1", SerchParam);
            }
            else
            {
                using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
                {
                    var worksheet = workbook.Worksheets.Add("Report1wave");
                    worksheet.Cell(1, 1).Value = "ЗМ";
                    worksheet.Cell(1, 2).Value = "Регион";
                    worksheet.Cell(1, 3).Value = "Филиал";
                    worksheet.Cell(1, 4).Value = "Номер БС";
                    worksheet.Cell(1, 5).Value = "Наименование БС";
                    worksheet.Cell(1, 6).Value = "ДС";
                    worksheet.Cell(1, 7).Value = "Дополнение";
                    worksheet.Cell(1, 8).Value = "Поставщик";
                    worksheet.Cell(1, 9).Value = "ВИР дата";
                    worksheet.Cell(1, 10).Value = "Сумма";
                    worksheet.Cell(1, 11).Value = "Инициатор";
                    worksheet.Cell(1, 12).Value = "Ответственный";
                    worksheet.Cell(1, 13).Value = "Этап";
                    worksheet.Cell(1, 14).Value = "Статус";
                    worksheet.Cell(1, 15).Value = "Обработка";
                    worksheet.Cell(1, 16).Value = "ВИР_Тип_документа";
                    worksheet.Cell(1, 17).Value = "ВИР_Дополнение";
                    worksheet.Cell(1, 18).Value = "PR_Номер";
                    worksheet.Cell(1, 19).Value = "PR_статус";
                    worksheet.Cell(1, 20).Value = "PR_Комментарий";
                    worksheet.Cell(1, 21).Value = "СЭВД";
                    worksheet.Cell(1, 22).Value = "СЭВД_Номер";
                    worksheet.Cell(1, 23).Value = "ЕСМ_ссылка";
                    worksheet.Cell(1, 24).Value = "ДС_Дата";
                    worksheet.Cell(1, 25).Value = "ГФК";
                    worksheet.Cell(1, 26).Value = "ВИР_Начало_работ";
                    worksheet.Cell(1, 27).Value = "ВИР_Завершение_работ";
                    worksheet.Cell(1, 28).Value = "ВИР_Дата_интеграции";
                    worksheet.Cell(1, 29).Value = "Диадок_Дата_загрузки";
                    worksheet.Cell(1, 30).Value = "Диадок_Дата_подписания";
                    worksheet.Cell(1, 31).Value = "IMS_ссылка";
                    worksheet.Cell(1, 32).Value = "Диадок_ID";
                    worksheet.Cell(1, 33).Value = "Диадок_ссылка";
                    worksheet.Cell(1, 34).Value = "NRI_Код_проекта";
                    worksheet.Cell(1, 35).Value = "Контракт_номер";
                    worksheet.Cell(1, 36).Value = "Договор_номер";
                    worksheet.Cell(1, 37).Value = "Договор_дата";
                    worksheet.Cell(1, 38).Value = "Инициатор_почта";
                    worksheet.Cell(1, 39).Value = "Поставщик_ИНН";
                    worksheet.Cell(1, 40).Value = "Ошибка1";
                    worksheet.Cell(1, 41).Value = "Ошибка2";
                    worksheet.Cell(1, 42).Value = "Тех_Ошибка";
                    worksheet.Cell(1, 43).Value = "NRI_ссылка";
                    worksheet.Cell(1, 44).Value = "ВИР_Условия_платежа";
                    worksheet.Cell(1, 45).Value = "География";
                    worksheet.Cell(1, 46).Value = "ЗП_Номер";
                    worksheet.Cell(1, 47).Value = "ЗП_Статус";
                    worksheet.Cell(1, 48).Value = "БД_комментарий";
                    worksheet.Cell(1, 49).Value = "PR_файл";
                    worksheet.Cell(1, 50).Value = "ВИР_комментарий";
                    worksheet.Cell(1, 51).Value = "Дубль";
                    worksheet.Cell(1, 52).Value = "ВИР_Диапазоны";
                    worksheet.Cell(1, 53).Value = "Проставление";
                    worksheet.Cell(1, 54).Value = "Дозаполнение_ЕСМ";
                    worksheet.Row(1).Style.Font.Bold = true;
                    int rowi = 2;
                    //нумерация строк/столбцов начинается с индекса 1 (не 0)
                    foreach (MainReportWave1 row in _data)
                    {
                        worksheet.Cell(rowi, 1).Value = row.ZM_LOT;
                        worksheet.Cell(rowi, 2).Value = row.REGION;
                        worksheet.Cell(rowi, 3).Value = row.FILIAL;
                        worksheet.Cell(rowi, 4).Value = row.NRI_BS_N;
                        worksheet.Cell(rowi, 5).Value = row.NRI_BS_NAME;
                        worksheet.Cell(rowi, 6).Value = row.DS_N;
                        worksheet.Cell(rowi, 7).Value = row.VIR_DOP_N;
                        worksheet.Cell(rowi, 8).Value = row.PROVIDER;
                        worksheet.Cell(rowi, 9).Value = row.VIR_DATE;
                        worksheet.Cell(rowi, 10).Value = row.VIR_SUMM_WO_NDS;
                        worksheet.Cell(rowi, 11).Value = row.INITIATOR_FIO;
                        worksheet.Cell(rowi, 12).Value = row.RESPONSIBLE_FIO;
                        worksheet.Cell(rowi, 13).Value = row.STAGE;
                        worksheet.Cell(rowi, 14).Value = row.STATUS;
                        worksheet.Cell(rowi, 15).Value = row.PROCESSING;
                        worksheet.Cell(rowi, 16).Value = row.VIR_DOC_TYPE;
                        worksheet.Cell(rowi, 17).Value = row.VIR_DOP;
                        worksheet.Cell(rowi, 18).Value = row.PR_N;
                        worksheet.Cell(rowi, 19).Value = row.PR_STATUS;
                        worksheet.Cell(rowi, 20).Value = row.PR_COM;
                        worksheet.Cell(rowi, 21).Value = row.SEVD;
                        worksheet.Cell(rowi, 22).Value = row.SEVD_N;
                        worksheet.Cell(rowi, 23).Value = row.ECM_LINK;
                        worksheet.Cell(rowi, 24).Value = row.DS_DATE;
                        worksheet.Cell(rowi, 25).Value = row.GFK;
                        worksheet.Cell(rowi, 26).Value = row.VIR_START_WORK;
                        worksheet.Cell(rowi, 27).Value = row.VIR_END_WORK;
                        worksheet.Cell(rowi, 28).Value = row.VIR_INTEGRATION_DATE;
                        worksheet.Cell(rowi, 29).Value = row.DIADOK_UPLOAD_DATE;
                        worksheet.Cell(rowi, 30).Value = row.DIADOK_SIGN_DATE;
                        worksheet.Cell(rowi, 31).Value = row.IMS_LINK;
                        worksheet.Cell(rowi, 32).Value = row.DIADOK_ID;
                        worksheet.Cell(rowi, 33).Value = row.DIADOK_LINK;
                        worksheet.Cell(rowi, 34).Value = row.NRI_CODE_PROJECT;
                        worksheet.Cell(rowi, 35).Value = row.CONTRACT_N;
                        worksheet.Cell(rowi, 36).Value = row.DOG_N;
                        worksheet.Cell(rowi, 37).Value = row.DOG_DATE;
                        worksheet.Cell(rowi, 38).Value = row.INITIATOR_MAIL;
                        worksheet.Cell(rowi, 39).Value = row.PROVIDER_INN;
                        if (row.ERROR1.Length < 2000)
                        {
                            worksheet.Cell(rowi, 40).Value = row.ERROR1;
                        }
                        else
                        {
                            worksheet.Cell(rowi, 40).Value = row.ERROR1.Substring(0, 2000);
                        }
                        if (row.ERROR2.Length < 2000)
                        {
                            worksheet.Cell(rowi, 40).Value = row.ERROR2;
                        }
                        else
                        {
                            worksheet.Cell(rowi, 40).Value = row.ERROR2.Substring(0, 2000);
                        }
                        worksheet.Cell(rowi, 42).Value = row.TECH_ERROR;
                        worksheet.Cell(rowi, 43).Value = row.NRI_LINK;
                        worksheet.Cell(rowi, 44).Value = row.VIR_PAY_CONDITIONS;
                        worksheet.Cell(rowi, 45).Value = row.GEO;
                        worksheet.Cell(rowi, 46).Value = row.ZP_N;
                        worksheet.Cell(rowi, 47).Value = row.ZP_STATUS;
                        worksheet.Cell(rowi, 48).Value = row.BD_COM;
                        worksheet.Cell(rowi, 49).Value = row.PR_FILE;
                        worksheet.Cell(rowi, 50).Value = row.VIR_COM;
                        worksheet.Cell(rowi, 51).Value = row.DOUBLE;
                        worksheet.Cell(rowi, 52).Value = row.VIR_DIAP;
                        worksheet.Cell(rowi, 53).Value = row.PROSTAVLENIE;
                        worksheet.Cell(rowi, 54).Value = row.ECM_FILL;
                        rowi += 1;
                    }
                    _data = null;
                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        stream.Flush();
                        return new FileContentResult(stream.ToArray(),
                            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                        {
                            FileDownloadName = $"CESS_WAVE_1_REPORT_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                        };
                    }

            }
            }
        }
        public ActionResult HowToSearch(string id)
        {
            switch (Access.IsAccess(_service, "P_CESS_READER"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            return PartialView();
        }
        public ActionResult InProcess(int id)
        {
            switch (Access.IsAccess(_service, "BaseRight"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            return PartialView();
        }
    }
}
