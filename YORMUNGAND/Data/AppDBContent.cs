using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {

        }
        public DbSet<QueueItemID> QueueItemIDs { get; set; }
        public DbSet<Cess76Int> Cess76Ints { get; set; }
        public DbSet<AccessUsers> AccessUsers { get; set; }
        public DbSet<AccessRole> AccessRole { get; set; }
        public DbSet<AccessUserRole> AccessUserRole { get; set; }
        public DbSet<AccessRolePermissions> AccessRolePermissions { get; set; }
        public DbSet<AccessPermissions> AccessPermissions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QueueItemID>()
                .HasOne(p => p.CESS76INT)
                .WithOne(b => b.QUEUEITEMID)
                .HasForeignKey<Cess76Int>(p => p.QUEUEITEMID_REF);

            modelBuilder.Entity<AccessUserRole>()
                .HasOne(p => p.ACCESSUSERS)
                .WithMany(b => b.ACCESSUSERROLE);

            modelBuilder.Entity<AccessUserRole>()
                .HasOne(p => p.ACCESSROLE)
                .WithMany(b => b.ACCESSUSERROLE);

            modelBuilder.Entity<AccessRolePermissions>()
                .HasOne(p => p.ACCESSROLE)
                .WithMany(b => b.ACCESSROLEPERMISSIONS);

            modelBuilder.Entity<AccessRolePermissions>()
                .HasOne(p => p.ACCESSPERMISSIONS)
                .WithMany(b => b.ACCESSROLEPERMISSIONS);
        }
    }
}
