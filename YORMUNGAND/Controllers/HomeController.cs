using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Controllers
{
    public class HomeController : Controller
    {
        protected static IServiceProvider _service;
        public HomeController (IServiceProvider service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            Access.IniUser(_service);

            return View();
        }
    }
}
