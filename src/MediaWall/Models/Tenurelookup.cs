using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Tenurelookup
    {
        public Tenurelookup()
        {
            Faculty = new HashSet<Faculty>();
        }

        public string TenureStatus { get; set; }

        public virtual ICollection<Faculty> Faculty { get; set; }
    }
}
