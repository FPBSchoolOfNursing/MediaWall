using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Activities
    {
        public int ActivityId { get; set; }
        public string CaseUserId { get; set; }
        public string ActivityType { get; set; }
        public string ActivityName { get; set; }
        public string ActivityDescription { get; set; }
        public string OtherExplain { get; set; }
        public bool? IsInternational { get; set; }
        public string PersonRole { get; set; }
        public string GroupName { get; set; }
        public string Location { get; set; }
        public string CreditHours { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Faculty CaseUser { get; set; }
    }
}
