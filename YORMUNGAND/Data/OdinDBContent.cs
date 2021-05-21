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
    public class OdinDBContent : DbContext
    {
        public OdinDBContent(DbContextOptions<OdinDBContent> options) : base(options)
        {

        }
        public DbSet<Machine> Machine { get; set; }
        public DbSet<Process> Process { get; set; }
        public DbSet<ProcessChild> ProcessChild { get; set; }
        public DbSet<QueueProcesses> QueueProcesses { get; set; }
        public DbSet<DefaultQueueProcesses> DefaultQueueProcesses { get; set; }
        public DbSet<QueueProcessLog> QueueProcessLog { get; set; }
        public DbSet<SchedulerProcess> SchedulerProcess { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
