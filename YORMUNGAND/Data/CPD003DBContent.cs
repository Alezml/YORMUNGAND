using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using YORMUNGAND.Data.Models.ODIN;

namespace YORMUNGAND.Data
{
    public class CPD003DBContent : DbContext
    {
        public CPD003DBContent(DbContextOptions<OdinDBContent> options) : base(options)
        {

        }
        public DbSet<UserData> UserData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
