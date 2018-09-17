using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    }
}