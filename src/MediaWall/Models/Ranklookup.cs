using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Ranklookup
    {
        public Ranklookup()
        {
            Ranks = new HashSet<Ranks>();
            RanksOld = new HashSet<RanksOld>();
        }

        public string RankTitle { get; set; }

        public virtual ICollection<Ranks> Ranks { get; set; }
        public virtual ICollection<RanksOld> RanksOld { get; set; }
    }
}
