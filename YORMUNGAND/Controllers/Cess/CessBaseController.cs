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
    public class CessBaseController : Controller
    {
        private readonly AppDBContent _appDBContent;
        private AccessToolsRepository _rep;
        protected static IServiceProvider _service;
        public CessBaseController(IServiceProvider service, AppDBContent appDBContent)
        {
            _service = service;
            _appDBContent = appDBContent;
            _rep = new AccessToolsRepository(_appDBContent);
        }
        public IActionResult index()
        {
            switch (Access.IsAccess(_service, "P_CESS_READER"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "ЦЭСС";
            return View();
        }

        [Route("CESSBASE/USER")]
        public IActionResult UsersCess()
        {
            switch (Access.IsAccess(_service, "P_CESS_ADMIN"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление пользователями";
            return View(_rep.GetAllUsers());
        }
        //получить список ролей только для цесс
        public IActionResult AddRoleToUserCess(string user)
        {
            switch (Access.IsAccess(_service, "P_CESS_ADMIN"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.User = user;
            List<string> cessrolelist = new List<string> { "R_CESS_EDITOR", "R_CESS_READER", "R_CESS_ADMIN" };
            return View(_rep.GetRoleByUserAndOther(user).Where(c => cessrolelist.Contains(c.one)));
        }
    }
}
