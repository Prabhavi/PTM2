using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrackerModuleV1._0.Models.PTM;

namespace TrackerModuleV1._0.Data
{
    public class DummyData
    {
        public static List<Project> getProjects()
        {
            List<Project> projects = new List<Project>()
            {
                new Project()
                {
                    ProjectName="Wafer Sorter",
                    users=new List<User>()


                },
                new Project()
                {
                    ProjectName="Bakeout Chamber",
                    users=new List<User>()
                },
                new Project()
                {
                    ProjectName="Process Kit Transporter",
                    users=new List<User>()
                },
                new Project()
                {
                    ProjectName="Carbon Nanotube CVD Chamber",
                    users=new List<User>()
                }
            };
            return projects;
            
         }
        public static List<User> getUsers(PTMContex context)
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    FirstName="Leo",
                    LastName="Passion",
                    JobRole="Engineer",
                    
                   // projects=new List<Project>()
                    //ProjectNumber=context.Projects.Find(3).ProjectId,
                    
                },
                new User()
                {
                    FirstName="Abienash",
                    LastName="Thangavel",
                    JobRole="Design Engineer",
                     //projects=new List<Project>()
                   // ProjectNumber=context.Projects.Find(1).ProjectId,

                },
                new User()
                {
                    FirstName="Alex",
                    LastName="Daniel",
                    JobRole="Design Engineer",
                     projects=new List<Project>()
                    //ProjectNumber=context.Projects.Find(1).ProjectId,

                },
                new User()
                {
                    FirstName="Danny",
                    LastName="Edward",
                    JobRole="Design Engineer",
                    // projects=new List<Project>()
                    //ProjectNumber=context.Projects.Find(1).ProjectId,

                },
                new User()
                {
                    FirstName="Devinda",
                    LastName="Liyanage",
                    JobRole="R@D Engineer",
                     //projects=new List<Project>()
                   // ProjectNumber=context.Projects.Find(4).ProjectId,

                },
                new User()
                {
                    FirstName="Chamali",
                    LastName="Liyanage",
                    JobRole="R@D Engineer",
                     //projects=new List<Project>()
                   // ProjectNumber=context.Projects.Find(4).ProjectId,

                }
            };
            return users;
        }

        
        
    }
}