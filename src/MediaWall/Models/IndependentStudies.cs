using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class IndependentStudies
    {
        public int Isid { get; set; }
        public int? Arptid { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string Topic { get; set; }

        public virtual Arpt Arpt { get; set; }
    }
}
