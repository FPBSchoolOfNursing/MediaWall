using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class DoctoralCommittees
    {
        public int Did { get; set; }
        public string CaseUserId { get; set; }
        public string CommitteeName { get; set; }
        public string CommitteeLocale { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string DmstudentId { get; set; }
        public string OtherExplain { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Faculty CaseUser { get; set; }
        public virtual Doctoralcommitteeslocalelookup CommitteeLocaleNavigation { get; set; }
        public virtual Doctoralcommitteeslookup CommitteeNameNavigation { get; set; }
    }
}
