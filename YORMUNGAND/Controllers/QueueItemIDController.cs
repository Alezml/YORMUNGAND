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
        [Route("Cars/List")]
        //[Route("Cars/List/{category}")]

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<QueueItemID> ids = null;
            string currCategory = "";
            
            ids = _allids.QueueItems.OrderBy(i => i.QID);
            
            var idsObj = new IdsListViewModel
            {
                allIds = ids,
            };
            ViewBag.Title = "Страница с автомобилями";


            return View(idsObj);
        }
    }
}
