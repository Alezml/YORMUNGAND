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
        public RPABaseController(IServiceProvider service, AppDBContent appDBContent)
        {
            _service = service;
            _appDBContent = appDBContent;
            _rep = new AccessToolsRepository(_appDBContent);
        }
        public IActionResult index()
        {
            if (!Access.IsAccess(_service, "RPA"))
            {
                return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "RPA";
            return View();
        }
        [Route("RPABASE/PERMISSIONS")]
        public IActionResult Permissions()
        {
            if (!Access.IsAccess(_service, "RPA"))
            {
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
            if (!Access.IsAccess(_service, "RPA"))
            {
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
            if (!Access.IsAccess(_service, "RPA"))
            {
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
            if (!Access.IsAccess(_service, "RPA"))
            {
                return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление ролями";

            AccessRoleForm ARL = _rep.AddNewRole(inptForm);
            ARL.ACCESSROLE = _rep.GetAllRole();
            return View(ARL);
        }
        public IActionResult AddPermToRole(string role)
        {
            ViewBag.Role = role;
            ViewBag.RoleDesc = _rep.GetRoleDesc(role);
            return View(_rep.GetPermByRoleAndOther(role));
        }
        [Route("RPABASE/USER")]
        public IActionResult Users()
        {
            if (!Access.IsAccess(_service, "RPA"))
            {
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
    }
}
