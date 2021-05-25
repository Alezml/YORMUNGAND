using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;
using YORMUNGAND.Data.Models.ODIN;
using YORMUNGAND.Data.Repository;

namespace YORMUNGAND.Controllers
{
    public class OdinBaseController : Controller
    {
        private OdinRepository _rep;
        private OdinDBContent _odinDBContent;

        private BPdev1Repository _repBPd1;
        private BPdev1DBContent _bpd1DBContent;


        protected static IServiceProvider _service;
        public OdinBaseController(IServiceProvider service, OdinDBContent odinDBContent, BPdev1DBContent bpd1DBContent)
        {
            _odinDBContent = odinDBContent;
            _rep = new OdinRepository(_odinDBContent);
            _bpd1DBContent = bpd1DBContent;
            _repBPd1 = new BPdev1Repository(_bpd1DBContent);
            _service = service;
        }
        [Route("SS/TEST")]
        public IActionResult SS_Test()
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление машинками";
            var test = _repBPd1.GetAllApprovedProcess();
            foreach (var item in test)
            {
                var x = item.name;
            }

            MachineForm MF = new MachineForm();
            MF.MachineList = _rep.GetAllMachines();
            MF.machineName = "Введите имя машинки";
            return View(MF);
        }

        [Route("SS/MACHINE")]
        public IActionResult SS_Machine()
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление машинками";
            MachineForm MF = new MachineForm();
            MF.MachineList = _rep.GetAllMachines();
            MF.machineName = "Введите имя машинки";
            return View(MF);
        }
        [HttpPost]
        [Route("SS/MACHINE")]
        public IActionResult SS_Machine(MachineForm inptForm)
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление машинками";
            MachineForm MF = new MachineForm();
            MF.machineName = _rep.AddNewMachine(inptForm);
            MF.MachineList = _rep.GetAllMachines();
            return View(MF);
        }
        [Route("SS/PROCESS")]
        public IActionResult SS_Process()
        {
            switch (Access.IsAccess(_service, "RPA"))
            {
                case "wrongagent":
                    return RedirectToAction("WrongAgent", "Access");
                case "false":
                    return RedirectToAction("NoAccess", "Access");
            }
            ViewBag.Title = "Управление процессами";

            MachineForm MF = new MachineForm();
            return View(MF);
        }
    }
}
