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
    public class TestController : Controller
    {
        private readonly ITest _allids;
        public TestController(ITest iAllids)
        {
            _allids = iAllids;
        }
        [Route("TEST/ids")]

        //[Route("CESS/{id}")]
        public ViewResult List(string id)
        {

            IEnumerable<TestModel> ids = null;

            ids = _allids.TestModels.OrderBy(i => i.Test3);

            ViewBag.Title = "TEST -=- TEST";
            return View(ids);
        }
    }
}
