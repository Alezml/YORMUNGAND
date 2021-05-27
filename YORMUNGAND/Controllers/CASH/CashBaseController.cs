using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;
using YORMUNGAND.Data.Repository;

namespace YORMUNGAND.Controllers
{
    public class CashBaseController : Controller
    {
        private readonly AppDBContent _appDBContent;
        private CashToolsRepository _rep;
        private AccessToolsRepository _repA;
        protected static IServiceProvider _service;
        public CashBaseController(IServiceProvider service, AppDBContent appDBContent)
        {
            _service = service;
            _appDBContent = appDBContent;
            _rep = new CashToolsRepository(_appDBContent);
            _repA = new AccessToolsRepository(_appDBContent);
        }
        public IActionResult index()
        {
            switch (Access.IsAccess(_service, "P_CASH_READER"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Блокировка работы робота в ЕСМ";
            return View();
        }

        [Route("CASH/BLOCK")]
        public IActionResult Block()
        {
            switch (Access.IsAccess(_service, "P_CASH_READER"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Блокировка работы робота в ЕСМ";
            return View(_rep.GetCashBlock());
        }
        [HttpPost]
        [Route("CASH/BLOCK")]
        public IActionResult Block(CashBlockUF _cashblockUF)
        {
            switch (Access.IsAccess(_service, "P_CASH_EDITOR"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Блокировка работы робота в ЕСМ";
            var username = Access.GetUserName(_service);
            return View(_rep.AddCashBlock(_cashblockUF.DATE, username));
        }
        public IActionResult Unlock()
        {
            switch (Access.IsAccess(_service, "P_CASH_EDITOR"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Блокировка работы робота в ЕСМ";
            _rep.Unlock();
            return RedirectToAction("Block");
        }
        public IActionResult NewRI()
        {
            switch (Access.IsAccess(_service, "P_CASH_EDITOR"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Блокировка работы робота в ЕСМ";
            return RedirectToAction("Block");
        }
        [Route("CASHBASE/USER")]
        public IActionResult UsersCash()
        {
            switch (Access.IsAccess(_service, "P_CASH_ADMIN"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление пользователями";
            return View(_repA.GetAllUsers());
        }
        public IActionResult AddRoleToUserCash(string user)
        {
            switch (Access.IsAccess(_service, "P_CASH_ADMIN"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.User = user;
            List<string> cessrolelist = new List<string> { "R_CASH_EDITOR", "R_CASH_READER", "R_CASH_ADMIN" };
            return View(_repA.GetRoleByUserAndOther(user).Where(c => cessrolelist.Contains(c.one)));
        }
    }
}
