using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Servicecommitteetypeslookup
    {
        public Servicecommitteetypeslookup()
        {
            ServiceCommittees = new HashSet<ServiceCommittees>();
        }

        public string CommitteeType { get; set; }

        public virtual ICollection<ServiceCommittees> ServiceCommittees { get; set; }
    }
}
