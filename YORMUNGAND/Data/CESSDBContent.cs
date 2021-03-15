using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;

namespace YORMUNGAND.Data
{
    
    public class CESSDBContent : DbContext
    {
        public CESSDBContent(DbContextOptions<CESSDBContent> options) : base(options)
        {

        }

        public DbSet<MainReportWave1> MAIN_1 { get; set; }
        public DbSet<TestModel> TEST { get; set; }

    }
}
