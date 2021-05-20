using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data.Repository;
using YORMUNGAND.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace YORMUNGAND.Data.Models
{
    public class VIRCommentAnalitics
    {
        public int id { set; get; }
        public string AUTHOR { set; get; }
        public string SQL_STRING { set; get; }
        public string COMMENT { set; get; }
        public DateTime START_TIME { set; get; }
        public DateTime END_TIME { set; get; }
        public bool ENABLE { set; get; }
    }
}
