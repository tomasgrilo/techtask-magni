using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagniCollegium.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxStudents { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
    }
}