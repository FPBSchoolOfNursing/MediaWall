using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Doctoralcommitteeslookup
    {
        public Doctoralcommitteeslookup()
        {
            DoctoralCommittees = new HashSet<DoctoralCommittees>();
        }

        public string CommitteeName { get; set; }

        public virtual ICollection<DoctoralCommittees> DoctoralCommittees { get; set; }
    }
}
