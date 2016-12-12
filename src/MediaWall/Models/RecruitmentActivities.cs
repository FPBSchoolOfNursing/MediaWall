using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class RecruitmentActivities
    {
        public int Raid { get; set; }
        public int? Sid { get; set; }
        public string Activity { get; set; }
        public string GroupName { get; set; }
        public string ActivityDate { get; set; }
        public string Location { get; set; }

        public virtual Services S { get; set; }
    }
}
