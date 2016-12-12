using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class AbsentDurationLookup
    {
        public AbsentDurationLookup()
        {
            Absences = new HashSet<Absences>();
        }

        public string Duration { get; set; }

        public virtual ICollection<Absences> Absences { get; set; }
    }
}
