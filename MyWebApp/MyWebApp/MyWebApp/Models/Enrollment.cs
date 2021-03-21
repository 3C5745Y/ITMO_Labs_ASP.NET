using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int ProjectID { get; set; }
        public int InternID { get; set; }

        public virtual Project Project { get; set; }
        public virtual Intern Intern { get; set; }
    }
}