using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class FacultyCourse
    {
        public int Cid { get; set; }
        public string CaseUserId { get; set; }
        public string Role { get; set; }
        public double? HoursPerWeek { get; set; }
        public double? CreditHoursTaught { get; set; }

        public virtual Faculty CaseUser { get; set; }
        public virtual Courses C { get; set; }
        public virtual Rolelookup RoleNavigation { get; set; }
    }
}
