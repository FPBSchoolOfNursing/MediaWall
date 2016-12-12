using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class MeetingAttendence
    {
        public int Aids { get; set; }
        public int? MeetingId { get; set; }
        public string FacultyNameId { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }
        public string Fname { get; set; }
        public string Role { get; set; }
        public string Dmid { get; set; }
        public string CaseUserId { get; set; }

        public virtual Faculty CaseUser { get; set; }
        public virtual Meetings Meeting { get; set; }
    }
}
