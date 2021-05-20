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
        private readonly eCESSDBContent _ecessDBContent;
        private AccessToolsRepository _rep;
        private CessToolsRepository _repCT;
        protected static IServiceProvider _service;
        public CessBaseController(IServiceProvider service, AppDBContent appDBContent, eCESSDBContent ecessDBContent)
        {
            _service = service;
            _appDBContent = appDBContent;
            _ecessDBContent = ecessDBContent;
            _rep = new AccessToolsRepository(_appDBContent);
            _repCT = new CessToolsRepository(_appDBContent, _ecessDBContent);
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
        //Строки для анализа наименования работ для составления комментария ВИР
        [Route("CESSBASE/VIRCOMMENTANALITICS")]
        public IActionResult VIRCOM()
        {
            switch (Access.IsAccess(_service, "P_CESS_ADMIN"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Анализ наименования работ по ТЦП для составления комментария ВИР";
            VIRCommentAnaliticsForm VCA = new VIRCommentAnaliticsForm();
            VCA.COMMENTS = _repCT.GetAllVirCommentAnalitics();
            return View(VCA);
        }
        [HttpPost]
        [Route("CESSBASE/VIRCOMMENTANALITICS")]
        public IActionResult VIRCOM(VIRCommentAnaliticsForm inptForm)
        {
            switch (Access.IsAccess(_service, "P_CESS_ADMIN"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Анализ наименования работ по ТЦП для составления комментария ВИР";

            VIRCommentAnaliticsForm VCA = _repCT.AddNewVirCommentAnalitics(inptForm, Access.GetUserName(_service));
            VCA.COMMENTS = _repCT.GetAllVirCommentAnalitics();
            return View(VCA);
        }
        public IActionResult DeleteVirCom(int id)
        {
            _repCT.DeleteVirCom(id);
            return RedirectToAction("VIRCOM");
        }
    }
}
