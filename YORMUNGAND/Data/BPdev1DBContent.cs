using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;
using YORMUNGAND.Data.Models.ODIN;

namespace YORMUNGAND.Data
{
    
    public class BPdev1DBContent : DbContext
    {
        public BPdev1DBContent(DbContextOptions<BPdev1DBContent> options) : base(options)
        {

        }

        public DbSet<BPAProcess> BPAProcess { get; set; }
    }
}
