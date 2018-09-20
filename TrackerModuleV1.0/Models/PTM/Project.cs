using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrackerModuleV1._0.Models.PTM
{
    public class Project
    {
        //public Project()
        //{
        //    this.users = new HashSet<User>();
        //}
        [Key]
        public int ProjectId { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public string ShortDescription { get; set; }

        //public int UserId { get; set; }
        public virtual ICollection<User> users { get; set; }
    }
}