using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class DoctoralCommittees1
    {
        public int Did { get; set; }
        public int? Arptid { get; set; }
        public string CommitteeName { get; set; }
        public string CommitteeLocale { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Arpt Arpt { get; set; }
    }
}
