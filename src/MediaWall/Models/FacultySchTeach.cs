using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class FacultySchTeach
    {
        public string CaseUserId { get; set; }
        public string Dmid { get; set; }
        public string Role { get; set; }
        public decimal? HoursPerWeek { get; set; }

        public virtual Faculty CaseUser { get; set; }
        public virtual SchTeach Dm { get; set; }
        public virtual SchRoleLookup RoleNavigation { get; set; }
    }
}
