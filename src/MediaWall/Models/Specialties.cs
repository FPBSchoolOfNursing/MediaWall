using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Specialties
    {
        public int Sid { get; set; }
        public string CaseUserId { get; set; }
        public string Specialty { get; set; }
        public bool? IsResearchArea { get; set; }
        public bool? IsContributing { get; set; }
        public bool? IsReportable { get; set; }
        public string Dmid { get; set; }

        public virtual Faculty CaseUser { get; set; }
    }
}
