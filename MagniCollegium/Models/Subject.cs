using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagniCollegium.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}