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
    public class RPABaseController : Controller
    {
        protected static IServiceProvider _service;
        private readonly AppDBContent _appDBContent;
        private AccessToolsRepository _rep;
        private RPARepository _repR;
        private VBARepository _repV;
        public RPABaseController(IServiceProvider service, AppDBContent appDBContent)
        {
            _service = service;
            _appDBContent = appDBContent;
            _rep = new AccessToolsRepository(_appDBContent);
            _repR = new RPARepository(_appDBContent);
            _repV = new VBARepository(_appDBContent);
        }
        public IActionResult index()
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "RPA";
            return View();
        }
        [Route("RPABASE/PERMISSIONS")]
        public IActionResult Permissions()
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление правами";
            AccessPermissionsForm APF = new AccessPermissionsForm();
            APF.ACCESSPERMISSIONS = _rep.GetAllPermissons();
            return View(APF);
        }
        [HttpPost]
        [Route("RPABASE/PERMISSIONS")]
        public IActionResult Permissions(AccessPermissionsForm inptForm)
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление правами";

            AccessPermissionsForm APF = _rep.AddNewPermission(inptForm);
            APF.ACCESSPERMISSIONS = _rep.GetAllPermissons();
            return View(APF);
        }
        public IActionResult PermToRole()
        {
            return View();
        }
        public IActionResult PermToRole2()
        {
            return View();
        }
        public IActionResult PermToRole3()
        {
            return View();
        }
        public IActionResult PermToRole4()
        {
            ViewBag.Role = "SHERIFF";
            ViewBag.RoleDesc = "Описание Адм";
            return View(_rep.GetPermByRoleAndOther("SHERIFF"));
        }
        public IActionResult PermToRole5()
        {
            return View();
        }
        public IActionResult PermToRole6()
        {
            return View();
        }
        [Route("RPABASE/ROLE")]
        public IActionResult Role()
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление ролями";
            AccessRoleForm ARL = new AccessRoleForm();
            ARL.ACCESSROLE = _rep.GetAllRole();
            return View(ARL);
        }
        [HttpPost]
        [Route("RPABASE/ROLE")]
        public IActionResult Role(AccessRoleForm inptForm)
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление ролями";

            AccessRoleForm ARL = _rep.AddNewRole(inptForm);
            ARL.ACCESSROLE = _rep.GetAllRole();
            return View(ARL);
        }
        public IActionResult AddPermToRole(string role)
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Role = role;
            ViewBag.RoleDesc = _rep.GetRoleDesc(role);
            return View(_rep.GetPermByRoleAndOther(role));
        }
        [Route("RPABASE/USER")]
        public IActionResult Users()
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление пользователя";
            return View(_rep.GetAllUsers());
        }
        public IActionResult AddRoleToUser(string user)
        {
            ViewBag.User = user;
            return View(_rep.GetRoleByUserAndOther(user));
        }
        [Route("RPA/ALERTS")]
        public IActionResult Alerts()
        {
            switch (Access.IsAccess(_service, "P_RPA_VIEW_1"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Отслеживание алертов";
            AlertView alertview = new AlertView
            {
                Worked = _repR.GetWorkedAlerts(3),
                ToDo = _repR.GetToDoAlerts()
            };
            //if (alertview.ToDo.Count() == 0)
            //{
            //    alertview.TimeWOAlerts = DateTime.Now - _repR.GetLastAlertDate();
            //}
            return View(alertview);
        }
        [Route("RPA/ALERTDETAIL")]
        public IActionResult AlertDetail(int id)
        {
            switch (Access.IsAccess(_service, "P_RPA_VIEW_1"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Отслеживание алертов";
            return View(_repR.GetAlertByID(id));
        }
        public IActionResult WorkAlert(int id)
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Отслеживание алертов";
            _repR.WorkAlert(id);
            return RedirectToAction("Alerts");
        }
        public IActionResult ToDoAlert(int id)
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Отслеживание алертов";
            _repR.ToDoAlert(id);
            return RedirectToAction("Alerts");
        }
        [Route("RPABASE/DEPLOY")]
        public IActionResult DeployReport()
        {
            return View();
        }
        [Route("RPABASE/VBAPROJECTS")]
        public IActionResult VBAPROJECTS()
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление проектами VBA";
            VBAprojectForm VPF = new VBAprojectForm();
            VPF.VBAPROJECTS = _repV.GetAllVBAprojects();
            return View(VPF);
        }
        [HttpPost]
        [Route("RPABASE/VBAPROJECTS")]
        public IActionResult VBAPROJECTS(VBAprojectForm inptForm)
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление проектами VBA";

            VBAprojectForm VPF = _repV.AddNewVBAproject(inptForm);
            VPF.VBAPROJECTS = _repV.GetAllVBAprojects();
            return View(VPF);
        }
        [Route("RPABASE/VBA")]
        public IActionResult VBA()
        {
            return View();
        }
    }
}
