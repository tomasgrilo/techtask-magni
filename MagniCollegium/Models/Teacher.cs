using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagniCollegium.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Salary { get; set; }
    }
}