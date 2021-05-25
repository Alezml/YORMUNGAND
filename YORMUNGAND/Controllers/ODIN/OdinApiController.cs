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
    public class OdinApiController : Controller
    {
        private OdinRepository _rep;
        private OdinDBContent _odinDBContent;

        private BPdev1Repository _repBPd1;
        private BPdev1DBContent _bpd1DBContent;

        private OdinMultiRepository _repOM;

        protected static IServiceProvider _service;
        public OdinApiController(IServiceProvider service, OdinDBContent odinDBContent, BPdev1DBContent bpd1DBContent)
        {
            _odinDBContent = odinDBContent;
            _rep = new OdinRepository(_odinDBContent);
            _bpd1DBContent = bpd1DBContent;
            _repBPd1 = new BPdev1Repository(_bpd1DBContent);
            _repOM = new OdinMultiRepository(_odinDBContent, _bpd1DBContent);
            _service = service;
        }
        [HttpPost]
        public string AddNewProcessByBpId(Guid guid)
        {
            return _repOM.AddNewProcessByBpId(guid);
        }
    }
}
