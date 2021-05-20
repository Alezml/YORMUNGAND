using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace YORMUNGAND.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<QueueItemID> QueueItemIDs { get; set; }
        public DbSet<Cess76Int> Cess76Ints { get; set; }
        public DbSet<AccessUsers> AccessUsers { get; set; }
        public DbSet<AccessRole> AccessRole { get; set; }
        public DbSet<AccessPermissions> AccessPermissions { get; set; }
        public DbSet<UserAgentLog> UserAgentLog { get; set; }
        public DbSet<CashBlock> CashBlock { get; set; }
        public DbSet<Alert> RPAAlert { get; set; }
        public DbSet<StatistikCessReportDwnld> StatCessReportDwnld { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QueueItemID>()
                .HasOne(p => p.CESS76INT)
                .WithOne(b => b.QUEUEITEMID)
                .HasForeignKey<Cess76Int>(p => p.QUEUEITEMID_REF);
        }
    }
}
