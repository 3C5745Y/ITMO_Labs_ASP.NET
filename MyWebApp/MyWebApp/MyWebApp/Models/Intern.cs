using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyWebApp.Models
{
    public class Intern
    {
        public int ID { get; set; }
        [DisplayName("Фамилия")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Имя")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Дата заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}