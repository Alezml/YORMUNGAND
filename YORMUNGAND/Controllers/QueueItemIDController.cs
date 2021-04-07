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
    public class QueueItemIDController : Controller
    {
        private readonly IALLids _allids;
        protected static IServiceProvider _service;

        public QueueItemIDController(IALLids iAllids, IServiceProvider service)
        {
            _allids = iAllids;
            _service = service;
        }
        [Route("CESS/ids")]

        //[Route("CESS/{id}")]
        public IActionResult List(string id)
        {

            if (!Access.IsAccess(_service, "BaseRight"))
            {
                return RedirectToAction("NoAccess", "Access");
            }
            IEnumerable<QueueItemID> ids = null;
            IEnumerable<QueueItemID> accid = null;
            IEnumerable<QueueItemID> finid = null;

            ids = _allids.QueueItems.Where(i => i.CESS76INT.STATUS.Equals("NEW")).OrderBy(i => i.QID);
            accid = _allids.QueueItems.Where(i => new[] { "TODO_FALSE", "TODO_OK" }.Contains(i.CESS76INT.STATUS)).OrderBy(i => i.QID);
            finid = _allids.QueueItems.Where(i => new[] { "FIN_FALSE", "FIN_OK"}.Contains(i.CESS76INT.STATUS)).OrderBy(i => i.QID);

            var idsObj = new IdsListViewModel
            {
                NewIds = ids,
                AcceptedIds = accid,
                FinishedIds = finid
            };
            ViewBag.Title = "ЦЭСС Инцидент №76";
            return View(idsObj);
        }
    }
}
