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
        public DetailItemController(IALLids iAllids)
        {
            _allids = iAllids;
        }
        [Route("DetailItem/{id}")]
        public ViewResult List(string QID)
        {

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
            return RedirectToAction(QID);
        }
    }
}
