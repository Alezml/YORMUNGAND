using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VALHALLA.Data.Models;
using YORMUNGAND.Data;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;
using YORMUNGAND.Data.Repository;

namespace YORMUNGAND.Controllers
{
    public class HRReportController : Controller
    {
        private readonly AppDBContent _appDBContent;
        private readonly VALHALLADBContent _valDBContent;
        private VALHALLARepository _valRep;
        protected static IServiceProvider _service;
        public HRReportController(IServiceProvider service, AppDBContent appDBContent, VALHALLADBContent valDBContent)
        {
            _appDBContent = appDBContent;
            _service = service;
            _valDBContent = valDBContent;
            _valRep = new VALHALLARepository(valDBContent, appDBContent);
        }
        [Route("HR/REPORTS/CHATBOT")]
        public IActionResult HrReportChatBot()
        {
            switch (Access.IsAccess(_service, "P_HR_READER"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            HR_REPORT_CHATBOT_MAIN_FS SerchParam = new HR_REPORT_CHATBOT_MAIN_FS();
            SerchParam.data = _valRep.ChatBotReport(SerchParam);
            //SerchParam.count = _rep.MainReportWave1c(SerchParam);
            //SerchParam.countTotal = _rep.MainReportWave1ct(SerchParam);
            //SerchParam.REGIONSELECT = _rep.GetSelectList("REGION", "Все регионы", "", "", "", "");
            //SerchParam.FILIALSELECT = _rep.GetSelectList("FILIAL", "Все филиалы", "", "", "", "");
            //SerchParam.STAGESELECT = _rep.GetSelectList("STAGE", "Все этапы", "", "", "", "");
            //SerchParam.PROCESSINGSELECT = _rep.GetSelectList("PROCESSING", "Все типы", "", "", "", "");
            ViewBag.Title = "ОТЧЕТ HR ОБРАЩЕНИЯ В ЧАТ БОТ";
            return View(SerchParam);
        }

        [HttpPost]
        [Route("HR/REPORTS/CHATBOT")]
        public IActionResult HrReportChatBot(HR_REPORT_CHATBOT_MAIN_FS SerchParam)
        {
            switch (Access.IsAccess(_service, "P_HR_READER"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            //SerchParam = MainReportWave1FS.Check(SerchParam);
            //SerchParam.count = _rep.MainReportWave1c(SerchParam);
            //SerchParam.countTotal = _rep.MainReportWave1ct(SerchParam);
            //if (SerchParam.page > (SerchParam.count / SerchParam.pagesize + (SerchParam.count % SerchParam.pagesize == 0 ? 0 : 1)))
            //{
            //    SerchParam.page = 1;
            //}
            //SerchParam.data = _rep.MainReportWave1ss(SerchParam);
            //SerchParam.REGIONSELECT = _rep.GetSelectList("REGION", "Все регионы", "", SerchParam.FILIAL, SerchParam.STAGE, SerchParam.PROCESSING);
            //SerchParam.FILIALSELECT = _rep.GetSelectList("FILIAL", "Все филиалы", SerchParam.REGION, "", SerchParam.STAGE, SerchParam.PROCESSING);
            //SerchParam.STAGESELECT = _rep.GetSelectList("STAGE", "Все этапы", SerchParam.REGION, SerchParam.FILIAL, "", SerchParam.PROCESSING);
            //SerchParam.PROCESSINGSELECT = _rep.GetSelectList("PROCESSING", "Все типы", SerchParam.REGION, SerchParam.FILIAL, SerchParam.STAGE, "");

            ViewBag.Title = "ОТЧЕТ HR ОБРАЩЕНИЯ В ЧАТ БОТ";
            return View(SerchParam);
        }

        public IActionResult AcceptInWork(int id)
        {
            switch (Access.IsAccess(_service, "BaseRight"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            var domainName = Access.GetUserName(_service).Split("\\")[1];
            var ud = Utility.GetUserDataByDomainName("hr report", domainName, out bool result);
            if(result)
            {
                _valRep.UpdateHRData(id, domainName, String.Format("{0} {1} {2}", ud.last_name, ud.first_name, ud.middle_names), ud.email_address);
            } else
            {
                _valRep.UpdateHRData(id, domainName);
            }
            _valRep.UpdateStatus(id, 2);
            return RedirectToAction("HrReportChatBot");
        }

        public IActionResult Complete(int id)
        {
            switch (Access.IsAccess(_service, "BaseRight"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            _valRep.UpdateStatus(id, 3);
            return RedirectToAction("HrReportChatBot");
        }

        public IActionResult ReturnInWork(int id)
        {
            switch (Access.IsAccess(_service, "BaseRight"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            _valRep.UpdateStatus(id, 2);
            return RedirectToAction("HrReportChatBot");
        }

        public IActionResult ReturnInWait(int id)
        {
            switch (Access.IsAccess(_service, "BaseRight"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            _valRep.UpdateHRData(id, null);
            _valRep.UpdateStatus(id, 1);
            return RedirectToAction("HrReportChatBot");
        }
        
    }
}
