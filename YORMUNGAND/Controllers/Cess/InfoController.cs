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
    public class InfoController : Controller
    {
        protected static IServiceProvider _service;
        public InfoController(IServiceProvider service)
        {
            _service = service;
        }
        public ActionResult Index()
        {
            switch (Access.IsAccess(_service, "BaseRight"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            return View();
        }
        public ActionResult HowToSearch(int d)
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
