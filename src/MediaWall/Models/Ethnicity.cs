using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Ethnicity
    {
        public int Eid { get; set; }
        public string CaseUserId { get; set; }
        public bool? IsCaucasian { get; set; }
        public bool? IsNativeAmerican { get; set; }
        public bool? IsAsian { get; set; }
        public bool? IsAfricanAmerican { get; set; }
        public bool? IsHispanic { get; set; }
        public bool? IsPacIslander { get; set; }
        public bool? IsOther { get; set; }

        public virtual Person CaseUser { get; set; }
    }
}
