using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagniCollegium.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int Score { get; set; }
        public Subject Subject { get; set; }
    }
}