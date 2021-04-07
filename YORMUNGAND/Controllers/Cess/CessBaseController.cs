using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Controllers
{
    public class CessBaseController : Controller
    {
        protected static IServiceProvider _service;
        public CessBaseController(IServiceProvider service)
        {
            _service = service;
        }
        public IActionResult index()
        {

            if (!Access.IsAccess(_service, "BaseRight"))
            {
                return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "ЦЭСС";
            return View();
        }
    }
}
