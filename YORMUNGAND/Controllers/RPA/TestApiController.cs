using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;
using YORMUNGAND.Data.Repository;

namespace YORMUNGAND.Controllers
{
    public class TestApiController : Controller
    {
        AppDBContent _appDBContent;
        AccessToolsRepository _rep;
        RPARepository _repR;
        VBARepository _repV;
        protected static IServiceProvider _service;
        public TestApiController(AppDBContent appDBContent, IServiceProvider service)
        {
            _appDBContent = appDBContent;
            _rep = new AccessToolsRepository(_appDBContent);
            _repR = new RPARepository(_appDBContent);
            _repV = new VBARepository(_appDBContent);
            _service = service;
        }

        [Route("Permissions")]
        public IEnumerable<AccessPermissions> GetProducts1()
        {
            var X = Access.IsAccess(_service, "P_RPA_VIEW_1");

            return _appDBContent.AccessPermissions.ToList();
        }
        [HttpPost]
        public IEnumerable<AccessPermissions> GetProducts(string role)
        {
            return _appDBContent.AccessPermissions.Where(c => c.PERMISSION != role).ToList();
        }
        [HttpPost]
        public string DeletePermFromRole(string role, string perm)
        {
            _rep.DeletePermFromRole(role, perm);
            return "Из роли " + _rep.GetRoleDesc(role) + " удалён доступ " + _rep.GetPermDesc(perm);
            //return "DEL " + role + " -=- " + perm;
        }
        [HttpPost]
        public string AddPermToRole(string role, string perm)
        {
            _rep.AddPermToRole(role, perm);
            return "В роль " + _rep.GetRoleDesc(role) + " добавлен доступ " + _rep.GetPermDesc(perm);
            //return "ADD " + role + " -=- " + perm;
        }
        [HttpPost]
        public string DeleteRoleFromUser(string user, string role)
        {
            _rep.DeleteRoleFromUser(user, role);
            return "У пользователя " + user + " удалена " + _rep.GetRoleDesc(role);
        }
        [HttpPost]
        public string AddRoleToUser(string user, string role)
        {
            _rep.AddRoleToUser(user, role);
            return "Пользователю " + user + " добавлена " + _rep.GetRoleDesc(role);
        }
        [HttpPost]
        public string CreateWarning(string proces, string tag, string errorMsg, string dolist)
        {
            _repR.AddAlert(proces, tag, errorMsg, dolist);
            return "SUCCESS";
        }
        [Route("VBALOG")]
        public string WriteVBAlog(int id)
        {
            _repV.WriteVBAlog(id);
            return "SUCCESS";
        }
        [Route("VBALOG2")]
        public string WriteVBAlog2(int id, double ver, string pcname)
        {
            _repV.WriteVBAlog2(id, ver, pcname);
            return "SUCCESS";
        }
        [Route("VBAVER1")]
        public string CheckVBAver1(int id, double ver)
        {
            return _repV.CheckVBAver(id, ver);
        }
    }
}
