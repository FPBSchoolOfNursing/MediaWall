using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class FacultyMeetingAttendance
    {
        public int Faid { get; set; }
        public int? Sid { get; set; }
        public bool? January { get; set; }
        public bool? February { get; set; }
        public bool? March { get; set; }
        public bool? April { get; set; }
        public bool? May { get; set; }
        public bool? June { get; set; }
        public bool? July { get; set; }
        public bool? August { get; set; }
        public bool? September { get; set; }
        public bool? October { get; set; }
        public bool? November { get; set; }
        public bool? December { get; set; }

        public virtual Services S { get; set; }
    }
}
