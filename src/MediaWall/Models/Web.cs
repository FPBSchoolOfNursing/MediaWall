using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Web
    {
        public int PublicationId { get; set; }
        public string WebSiteTitle { get; set; }
        public string WebPageTitle { get; set; }
        public string Url { get; set; }

        public virtual Publications Publication { get; set; }
    }
}
