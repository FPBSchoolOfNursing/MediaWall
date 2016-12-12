using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Rolelookup
    {
        public Rolelookup()
        {
            FacultyCourse = new HashSet<FacultyCourse>();
        }

        public string Role { get; set; }

        public virtual ICollection<FacultyCourse> FacultyCourse { get; set; }
    }
}
