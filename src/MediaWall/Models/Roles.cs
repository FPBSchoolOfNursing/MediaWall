using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Roles
    {
        public int Rid { get; set; }
        public string CaseUserId { get; set; }
        public string RoleTitle { get; set; }
        public int? NoHours { get; set; }
        public string RoleDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Faculty CaseUser { get; set; }
    }
}
