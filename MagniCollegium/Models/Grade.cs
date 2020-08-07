using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagniCollegium.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public int Score { get; set; }
        public virtual Subject Subject { get; set; }
    }
}