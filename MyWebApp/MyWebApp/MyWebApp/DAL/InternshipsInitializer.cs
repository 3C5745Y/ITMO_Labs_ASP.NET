using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MyWebApp.Models;

namespace MyWebApp.DAL
{
    public class InternshipsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<InternshipsContext>
    {
        protected override void Seed(InternshipsContext context)
        {
            var students = new List<Intern>
            {
            new Intern{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Intern{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Intern{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Intern{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Intern{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Intern{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            };

            students.ForEach(s => context.Interns.Add(s));
            context.SaveChanges();

            var courses = new List<Project>
            {
            new Project{ProjectID=1050,Title="WebTeam"},
            new Project{ProjectID=4022,Title="ToolBox App"},
            new Project{ProjectID=4041,Title="Marketing Automation" },
            new Project{ProjectID=1045,Title="Space"},
            new Project{ProjectID=3141,Title="New IDE"},
            new Project{ProjectID=2021,Title="Compiler"},
            };
            courses.ForEach(s => context.Projects.Add(s));
            context.SaveChanges();


            var enrollments = new List<Enrollment>
            {
            new Enrollment{InternID=1,ProjectID=1050 },
            new Enrollment{InternID=1,ProjectID=4022 },
            new Enrollment{InternID=1,ProjectID=4041 },
            new Enrollment{InternID=2,ProjectID=1045 },
            new Enrollment{InternID=2,ProjectID=3141 },
            new Enrollment{InternID=2,ProjectID=2021 },
            new Enrollment{InternID=3,ProjectID=1050},
            new Enrollment{InternID=4,ProjectID=1050,},
            new Enrollment{InternID=4,ProjectID=4022 },
            new Enrollment{InternID=5,ProjectID=4041 },
            new Enrollment{InternID=6,ProjectID=1045},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}