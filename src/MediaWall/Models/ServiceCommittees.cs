using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ServiceCommittees
    {
        public int Scid { get; set; }
        public int? Sid { get; set; }
        public string CommitteeType { get; set; }
        public string CommitteeName { get; set; }
        public string Activity { get; set; }
        public string Acomplishments { get; set; }
        public string Role { get; set; }
        public string OtherExplaination { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? HoursPerYear { get; set; }
        public bool? IsChair { get; set; }
        public bool? IsMember { get; set; }
        public bool? IsLeader { get; set; }
        public bool? IsGrantReviewer { get; set; }
        public bool? IsReviewPanel { get; set; }
        public bool? IsEditorialBoard { get; set; }

        public virtual Servicecommitteetypeslookup CommitteeTypeNavigation { get; set; }
        public virtual Services S { get; set; }
    }
}
