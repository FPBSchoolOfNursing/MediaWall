using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class EmergencyContact
    {
        public int Eid { get; set; }
        public string CaseUserId { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string WorkPhone { get; set; }
        public string WorkExt { get; set; }
        public string Pager { get; set; }
        public string OtherContact { get; set; }
        public string Relationship { get; set; }
        public string AdditionalInfo { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Person CaseUser { get; set; }
    }
}
