using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Committees
    {
        public int Cid { get; set; }
        public string CaseUserId { get; set; }
        public string CommitteeType { get; set; }
        public string Committee { get; set; }
        public string Position { get; set; }
        public string OtherExplain { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? HoursSpent { get; set; }
        public string Elected { get; set; }
        public string PaidStatus { get; set; }
        public string Audience { get; set; }
        public bool? ExOfficio { get; set; }
        public string Responsibilities { get; set; }
        public string Accomplishments { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Faculty CaseUser { get; set; }
        public virtual CommitteesLookup CommitteeTypeNavigation { get; set; }
    }
}
