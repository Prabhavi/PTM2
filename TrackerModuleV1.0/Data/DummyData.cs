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
                    ProjectName="Wafer Sorter"
                    
        
                },
                new Project()
                {
                    ProjectName="Bakeout Chamber"
                },
                new Project()
                {
                    ProjectName="Process Kit Transporter"
                },
                new Project()
                {
                    ProjectName="Carbon Nanotube CVD Chamber"
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
                    ProjectNumber=context.Projects.Find(3).ProjectId,
                    
                },
                new User()
                {
                    FirstName="Abienash",
                    LastName="Thangavel",
                    JobRole="Design Engineer",
                    ProjectNumber=context.Projects.Find(1).ProjectId,

                },
                new User()
                {
                    FirstName="Alex",
                    LastName="Daniel",
                    JobRole="Design Engineer",
                    ProjectNumber=context.Projects.Find(1).ProjectId,

                },
                new User()
                {
                    FirstName="Danny",
                    LastName="Edward",
                    JobRole="Design Engineer",
                    ProjectNumber=context.Projects.Find(1).ProjectId,

                },
                new User()
                {
                    FirstName="Devinda",
                    LastName="Liyanage",
                    JobRole="R@D Engineer",
                    ProjectNumber=context.Projects.Find(4).ProjectId,

                }
            };
            return users;
        }
    }
}