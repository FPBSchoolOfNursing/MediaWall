using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ObsoleteJournal
    {
        public int Puid { get; set; }
        public string JournalTitle { get; set; }
        public string Volume { get; set; }
        public string PageNumber { get; set; }
        public string Section { get; set; }

        public virtual ObsoletePublications Pu { get; set; }
    }
}
