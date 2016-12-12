using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class NonCreditInstruction
    {
        public int Ncid { get; set; }
        public string CaseUserId { get; set; }
        public string InstructionType { get; set; }
        public string OtherExplain { get; set; }
        public string Audience { get; set; }
        public string SponseringOrganization { get; set; }
        public int? NumberOfParticipants { get; set; }
        public string AcadOrProf { get; set; }
        public string Course { get; set; }
        public string Topic { get; set; }
        public int? ClassHours { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Faculty CaseUser { get; set; }
        public virtual Noncreditinstructionlookup InstructionTypeNavigation { get; set; }
    }
}
