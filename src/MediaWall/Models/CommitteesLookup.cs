using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class CommitteesLookup
    {
        public CommitteesLookup()
        {
            Committees = new HashSet<Committees>();
        }

        public string CommitteeType { get; set; }

        public virtual ICollection<Committees> Committees { get; set; }
    }
}
