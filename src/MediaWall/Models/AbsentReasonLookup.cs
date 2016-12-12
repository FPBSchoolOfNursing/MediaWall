using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class AbsentReasonLookup
    {
        public AbsentReasonLookup()
        {
            Absences = new HashSet<Absences>();
        }

        public string Reason { get; set; }

        public virtual ICollection<Absences> Absences { get; set; }
    }
}
