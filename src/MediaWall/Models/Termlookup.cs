using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Termlookup
    {
        public Termlookup()
        {
            Courses = new HashSet<Courses>();
            Utilization = new HashSet<Utilization>();
        }

        public string Term { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
        public virtual ICollection<Utilization> Utilization { get; set; }
    }
}
