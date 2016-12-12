using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ObsoleteWeb
    {
        public int Puid { get; set; }
        public string WebSiteTitle { get; set; }
        public string WebPageTitle { get; set; }
        public string Url { get; set; }

        public virtual ObsoletePublications Pu { get; set; }
    }
}
