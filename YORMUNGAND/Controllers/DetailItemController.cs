using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Controllers
{
    public class DetailItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
