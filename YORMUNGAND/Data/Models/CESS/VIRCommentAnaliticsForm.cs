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
    public class VIRCommentAnaliticsForm
    {
        public string SQL_STRING { set; get; }
        public string COMMENT { set; get; }
        public IEnumerable<VIRCommentAnalitics> COMMENTS { set; get; }
    }
}
