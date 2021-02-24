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
    public class Cess76DoSolController : Controller
    {
        private IALLids _qiRep;
        private readonly Cess76DoSol _dosol;
        public Cess76DoSolController(IALLids queueItemRepository, Cess76DoSol cess76DoSol)
        {
            _qiRep = queueItemRepository;
            _dosol = cess76DoSol;
        }

        public RedirectToActionResult ToDoOk(string QID)
        {
            var item = _qiRep.QueueItems.FirstOrDefault(i => i.QID == QID);
            if (item != null)
            {
                item.CESS76INT.STATUS = "TODO_OK";
                _dosol.AddToCart(item);
            }
            return RedirectToAction("ids", "Cess");
        }
        public RedirectToActionResult ToDoFalse(string QID)
        {
            var item = _qiRep.QueueItems.FirstOrDefault(i => i.QID == QID);
            if (item != null)
            {
                item.CESS76INT.STATUS = "TODO_FALSE";
                _dosol.AddToCart(item);
            }
            return RedirectToAction("ids", "Cess");
        }
        public RedirectToActionResult ToNew(string QID)
        {
            var item = _qiRep.QueueItems.FirstOrDefault(i => i.QID == QID);
            if (item != null)
            {
                item.CESS76INT.STATUS = "NEW";
                _dosol.AddToCart(item);
            }
            return RedirectToAction("ids", "Cess");
        }
    }
}
