using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagniCollegium.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int RegistationNumber { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}