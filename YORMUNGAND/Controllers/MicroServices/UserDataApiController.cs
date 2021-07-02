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
    public class UserDataApiController : Controller
    {
        AppDBContent _appDBContent;
        AccessToolsRepository _rep;
        RPARepository _repR;
        VBARepository _repV;
        protected static IServiceProvider _service;
        public UserDataApiController(AppDBContent appDBContent, IServiceProvider service)
        {
            _appDBContent = appDBContent;
            _rep = new AccessToolsRepository(_appDBContent);
            _repR = new RPARepository(_appDBContent);
            _repV = new VBARepository(_appDBContent);
            _service = service;
        }

        [Route("MS/test")]
        public string GetProducts1()
        {
            var X = Access.GetUserName(_service);

            return X;
        }
       
    }
}
