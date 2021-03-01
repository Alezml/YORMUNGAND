using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Access.Ini
            return View();
        }
    }
}
