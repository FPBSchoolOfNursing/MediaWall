using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Utilization
    {
        public int Uid { get; set; }
        public string CaseUserId { get; set; }
        public string Semester { get; set; }
        public int? Uyear { get; set; }
        public double? PercentEmployed { get; set; }
        public double? PercentTeaching { get; set; }
        public double? PercentResearch { get; set; }
        public double? PercentTraining { get; set; }
        public double? PercentOther { get; set; }
        public double? ExpectedTeachingHours { get; set; }
        public double? ActualTeachingHours { get; set; }
        public double? ClockedHours { get; set; }
        public string Comment { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Faculty CaseUser { get; set; }
        public virtual Termlookup SemesterNavigation { get; set; }
    }
}
