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

        public QueueItemIDController(IALLids iAllids)
        {
            _allids = iAllids;
        }
        [Route("CESS/ids")]

        public ViewResult List(string id)
        {

            IEnumerable<QueueItemID> ids = null;
            IEnumerable<QueueItemID> accid = null;
            ids = _allids.QueueItems.Where(i => i.CESS76INT.STATUS.Equals("NEW")).OrderBy(i => i.QID);
            accid= _allids.QueueItems.Where(i => new[] { "TODO_FALSE", "TODO_OK"}.Contains(i.CESS76INT.STATUS)).OrderBy(i => i.QID);

            var idsObj = new IdsListViewModel
            {
                NewIds = ids,
                AcceptedIds = accid
            };
            ViewBag.Title = "ЦЭСС Инцидент №76";

            return View(idsObj);
        }
    }
}
