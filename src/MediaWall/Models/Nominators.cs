using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Nominators
    {
        public int Nid { get; set; }
        public int? Hid { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Affiliation { get; set; }
        public string Comments { get; set; }

        public virtual Honors H { get; set; }
    }
}
