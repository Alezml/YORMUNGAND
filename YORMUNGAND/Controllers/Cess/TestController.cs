using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Controllers
{
    public class TestController : Controller
    {
        static List<TestModel> comps = new List<TestModel>();
        static TestController()
        {
            comps.Add(new TestModel { Id = 1, Name = "Apple II", Company = "Apple", Year = 1977 });
            comps.Add(new TestModel { Id = 2, Name = "Macintosh", Company = "Apple", Year = 1983 });
            comps.Add(new TestModel { Id = 3, Name = "IBM PC", Company = "IBM", Year = 1981 });
            comps.Add(new TestModel { Id = 4, Name = "Altair", Company = "MITS", Year = 1975 });
        }
        public ActionResult Index()
        {
            return View(comps);
        }
        public ActionResult List()
        {
            return View();
        }
        public ActionResult TestDetails()
        {
            return PartialView();
        }
    }
}
