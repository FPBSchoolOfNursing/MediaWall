using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ObsoleteBook
    {
        public int Puid { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Publisher { get; set; }
        public string Chapter { get; set; }

        public virtual ObsoletePublications Pu { get; set; }
    }
}
