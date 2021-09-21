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
    public class HRBaseController : Controller
    {
        private readonly AppDBContent _appDBContent;
        private AccessToolsRepository _rep;
        protected static IServiceProvider _service;
        public HRBaseController(IServiceProvider service, AppDBContent appDBContent)
        {
            _service = service;
            _appDBContent = appDBContent;
            _rep = new AccessToolsRepository(_appDBContent);
        }
        public IActionResult index()
        {
            switch (Access.IsAccess(_service, "P_HR_READER"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "HR";
            return View();
        }

        [Route("HRBASE/USER")]
        public IActionResult UsersHR()
        {
            switch (Access.IsAccess(_service, "P_HR_ADMIN"))
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
        public IActionResult AddRoleToUserHr(string user)
        {
            switch (Access.IsAccess(_service, "P_HR_ADMIN"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.User = user;
            List<string> hrrolelist = new List<string> { "R_HR_EDITOR", "R_HR_READER", "R_HR_ADMIN" };
            return View(_rep.GetRoleByUserAndOther(user).Where(c => hrrolelist.Contains(c.one)));
        }
    }
}
