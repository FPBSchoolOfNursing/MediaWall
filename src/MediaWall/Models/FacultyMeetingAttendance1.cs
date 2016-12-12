using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class FacultyMeetingAttendance1
    {
        public int Faid { get; set; }
        public int Sid { get; set; }
        public string Attendance { get; set; }
        public string ExcusedReason { get; set; }

        public virtual Services S { get; set; }
    }
}
