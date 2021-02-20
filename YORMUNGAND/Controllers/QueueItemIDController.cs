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
        private readonly byte _showType;

        public QueueItemIDController(IALLids iAllids)
        {
            _allids = iAllids;
        }
        [Route("ids")]
        [Route("ids/{id}")]

        public ViewResult List(string id, string date, string project)
        {

            IEnumerable<QueueItemID> ids = null;
            if (string.IsNullOrEmpty(id))
            {
                ids = _allids.QueueItems.OrderBy(i => i.QID);
            }
            else
            {
                ids = _allids.QueueItems.Where(i => i.QID.Equals(id)).OrderBy(i => i.QID);
            }

            var idsObj = new IdsListViewModel
            {
                allIds = ids,
                ShowType = 1
            };
            ViewBag.Title = "Страница с автомобилями " + date + " " + project;

            return View(idsObj);
        }
    }
}
