using Microsoft.AspNetCore.Http;
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
        private readonly ICessReport _cessReport;
        private readonly CESSDBContent _appDBContent;
        public CessReportController(ICessReport iCessReport, CESSDBContent appDBContent)
        {
            _cessReport = iCessReport;
            _appDBContent = appDBContent;
        }
        [Route("CESS/REPORTS/WAVE1/{page:int?}")]

        //[Route("CESS/{id}")]
        public ViewResult List(int page = 1)
        {

            IEnumerable<MainReportWave1> ids = null;
            var s = new CessReportRepository(_appDBContent);
            ids = s.MainReportWaves(page, 20);
            ViewBag.Title = "TEST -=- TEST ОТЧЕТ ЦЭСС ПЕРВАЯ ВОЛНА";
            return View(ids);
        }
    }
}
