using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class RanksOld
    {
        public string CaseUserId { get; set; }
        public string RankTitle { get; set; }
        public DateTime? PromotionDate { get; set; }
        public string Comments { get; set; }
        public bool? IsCurrent { get; set; }
        public DateTime? Dmdate { get; set; }
        public string Dmid { get; set; }

        public virtual Faculty CaseUser { get; set; }
        public virtual Ranklookup RankTitleNavigation { get; set; }
    }
}
