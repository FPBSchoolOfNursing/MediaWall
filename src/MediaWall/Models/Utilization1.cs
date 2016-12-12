using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Utilization1
    {
        public int Uid { get; set; }
        public string CaseUserId { get; set; }
        public decimal TeachingPts { get; set; }
        public decimal ResearchPts { get; set; }
        public decimal AdminPts { get; set; }
        public decimal OtherPts { get; set; }
        public decimal ExpectedPts { get; set; }
        public decimal? UtilizationPts { get; set; }
        public decimal? PlusMinus { get; set; }
        public decimal? UtilizationPercent { get; set; }
        public string Notes { get; set; }
        public int? Year { get; set; }

        public virtual Faculty CaseUser { get; set; }
    }
}
