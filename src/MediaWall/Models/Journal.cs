using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Journal
    {
        public int PublicationId { get; set; }
        public string JournalTitle { get; set; }
        public string Volume { get; set; }
        public string PageNumber { get; set; }
        public string Section { get; set; }

        public virtual Publications Publication { get; set; }
    }
}
