using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VALHALLA.Data.Models;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data
{
    public class VALHALLADBContent : DbContext
    {
        public VALHALLADBContent(DbContextOptions<VALHALLADBContent> options) : base(options)
        {

        }
        public DbSet<HR_REPORT_CHATBOT_MAIN> REPORT_MAIN { get; set; }
        public DbSet<HR_REPORT_CHATBOT_ROWS> REPORT_ROWS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
