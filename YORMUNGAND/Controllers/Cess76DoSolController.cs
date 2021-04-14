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
        protected static IServiceProvider _service;
        private IALLids _qiRep;
        private readonly Cess76DoSol _dosol;
        public Cess76DoSolController(IALLids queueItemRepository, Cess76DoSol cess76DoSol, IServiceProvider service)
        {
            _qiRep = queueItemRepository;
            _dosol = cess76DoSol;
            _service = service;
        }

        public RedirectToActionResult ToDoOk(string QID)
        {
            switch (Access.IsAccess(_service, "BaseRight"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
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
            switch (Access.IsAccess(_service, "BaseRight"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
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
            switch (Access.IsAccess(_service, "BaseRight"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
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
