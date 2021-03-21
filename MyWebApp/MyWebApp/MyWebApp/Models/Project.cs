using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MyWebApp.Models
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }
        [DisplayName("Название проекта")]
        public string Title { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
