using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Doctoralcommitteeslocalelookup
    {
        public Doctoralcommitteeslocalelookup()
        {
            DoctoralCommittees = new HashSet<DoctoralCommittees>();
        }

        public string CommitteeLocale { get; set; }

        public virtual ICollection<DoctoralCommittees> DoctoralCommittees { get; set; }
    }
}
