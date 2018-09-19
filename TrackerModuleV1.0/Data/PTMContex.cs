using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TrackerModuleV1._0.Models.PTM;

namespace TrackerModuleV1._0.Data
{
    public class PTMContex :DbContext
    {
        public PTMContex():base("DefaultConnection")
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<User>()
                .HasMany(i => i.projects)
                .WithMany(u => u.users)
                .Map(m =>
                {
                    m.ToTable("ProjectIdUserId");
                    m.MapLeftKey("ProjectId");
                    m.MapRightKey("UserId");
                });
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Project>()
            //    .HasMany(c => c.users).WithMany(i => i.projects)
            //    .Map(t => t.MapLeftKey("ProjectId")
            //        .MapRightKey("UserId")
            //        .ToTable("ProjectIdUserId"));
        }
    }
}