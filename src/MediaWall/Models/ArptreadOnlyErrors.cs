using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ArptreadOnlyErrors
    {
        public int Eid { get; set; }
        public int? Arptid { get; set; }
        public string Section { get; set; }
        public string SubSection { get; set; }
        public string Error { get; set; }
        public bool? IsFixed { get; set; }
        public string Comments { get; set; }

        public virtual Arpt Arpt { get; set; }
    }
}
