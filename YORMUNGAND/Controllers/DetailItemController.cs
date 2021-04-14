using Microsoft.AspNetCore.Mvc;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;
using YORMUNGAND.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Controllers
{
    public class DetailItemController : Controller
    {
        private readonly IALLids _allids;
        protected static IServiceProvider _service;
        public DetailItemController(IALLids iAllids, IServiceProvider service)
        {
            _allids = iAllids;
            _service = service;
        }
        [Route("DetailItem/{id}")]
        public IActionResult List(string QID) //IActionResult ViewResult
        {
            switch (Access.IsAccess(_service, "BaseRight"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            IEnumerable<QueueItemID> ids = null;
            ids = _allids.QueueItems.Where(i => i.QID.Equals(QID)).OrderBy(i => i.QID);
            var idsObj = new IdsListViewModel
            {
                AllIds = ids
            };
            ViewBag.Title = "ЦЭСС Инцидент №76 " + QID;
            return View(idsObj);
        }
        public RedirectToActionResult ShowDetail(string QID)
        {
            switch (Access.IsAccess(_service, "BaseRight"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            return RedirectToAction(QID);
        }
    }
}
