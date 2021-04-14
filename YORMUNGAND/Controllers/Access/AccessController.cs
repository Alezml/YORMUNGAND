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
    public class AccessController : Controller
    {
        public ActionResult NoAccess()
        {
            return PartialView();
        }
        public ActionResult WrongAgent()
        {
            return PartialView();
        }
    }
}
