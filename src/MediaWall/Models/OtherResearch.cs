using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class OtherResearch
    {
        public int Nrfid { get; set; }
        public int? Arptid { get; set; }
        public string NonFunded { get; set; }
        public string Additional { get; set; }

        public virtual Arpt Arpt { get; set; }
    }
}
