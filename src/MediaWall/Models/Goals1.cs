using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Goals1
    {
        public int Gid { get; set; }
        public string CaseUserId { get; set; }
        public int ReviewYear { get; set; }
        public string Goals { get; set; }
        public string GoalType { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Faculty CaseUser { get; set; }
    }
}
