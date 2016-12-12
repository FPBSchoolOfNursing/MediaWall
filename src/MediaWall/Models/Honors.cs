using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Honors
    {
        public Honors()
        {
            Nominators = new HashSet<Nominators>();
        }

        public int Hid { get; set; }
        public int? Arptid { get; set; }
        public string CaseUserId { get; set; }
        public string Award { get; set; }
        public string GrantingOrg { get; set; }
        public string OldAwardDate { get; set; }
        public int? AwardYear { get; set; }
        public string Location { get; set; }
        public string OldNominationDate { get; set; }
        public string AwardStatus { get; set; }
        public bool? IsResearchPubMat { get; set; }
        public string Comments { get; set; }
        public DateTime? AwardDate { get; set; }
        public DateTime? NominationDate { get; set; }
        public bool? IsAwarded { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual ICollection<Nominators> Nominators { get; set; }
        public virtual Arpt Arpt { get; set; }
        public virtual Faculty CaseUser { get; set; }
    }
}
