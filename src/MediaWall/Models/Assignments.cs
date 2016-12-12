using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Assignments
    {
        public string CaseUserId { get; set; }
        public int SectionId { get; set; }
        public string TeachingRole { get; set; }
        public decimal? TeachingPts { get; set; }
        public string DaysTaught { get; set; }
        public string Notes { get; set; }

        public virtual Faculty CaseUser { get; set; }
        public virtual CourseSection Section { get; set; }
        public virtual TeachingRole TeachingRoleNavigation { get; set; }
    }
}
