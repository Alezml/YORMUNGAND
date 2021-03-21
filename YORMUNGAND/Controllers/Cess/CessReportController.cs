﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        //private readonly ICessReport _cessReport;
        private readonly CESSDBContent _appDBContent;
        public CessReportController(CESSDBContent appDBContent) //ICessReport iCessReport, 
        {
            //_cessReport = iCessReport;
            _appDBContent = appDBContent;
        }
        //[Route("CESS/REPORTS/WAVE1/{page:int?}")]
        [Route("CESS/REPORTS/WAVE1")]
        //[Route("CESS/{id}")]
        public IActionResult List1(int page = 1)
        {
            MainReportWave1FS SerchParam = new MainReportWave1FS();
            var s = new CessReportRepository(_appDBContent);
            SerchParam.page = page;
            SerchParam = MainReportWave1FS.Check(SerchParam);
            SerchParam.data = s.MainReportWave1s(SerchParam);
            SerchParam.count = s.MainReportWave1c(SerchParam);
            //SerchParam = MainReportWave1FS.UnCheck(SerchParam);

            ViewBag.Title = "TEST ОТЧЕТ ЦЭСС ПЕРВАЯ ВОЛНА";

            //return RedirectToAction("List2", "CessReport", SerchParam);
            return View(SerchParam);
        }
        [HttpPost]
        public IActionResult List2(MainReportWave1FS SerchParam)
        {
            var s = new CessReportRepository(_appDBContent);

            SerchParam = MainReportWave1FS.Check(SerchParam);
            SerchParam.data = s.MainReportWave1s(SerchParam);

            SerchParam.count = s.MainReportWave1c(SerchParam);
            SerchParam = MainReportWave1FS.UnCheck(SerchParam);
            ViewBag.Title = "TEST -=- TEST ОТЧЕТ ЦЭСС ПЕРВАЯ ВОЛНА";

            return View(SerchParam);
        }
    }
}
