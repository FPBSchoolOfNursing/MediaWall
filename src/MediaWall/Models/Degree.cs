using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Degree
    {
        public int Did { get; set; }
        public string CaseUserId { get; set; }
        public string Degree1 { get; set; }
        public int GradYear { get; set; }
        public string University { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Major { get; set; }
        public bool? IsHighest { get; set; }
        public string OtherExplain { get; set; }
        public string Distinction { get; set; }
        public string DissertationTitle { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Person CaseUser { get; set; }
    }
}
