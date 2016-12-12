using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ServiceAttendance
    {
        public int Said { get; set; }
        public int? Sid { get; set; }
        public bool? AttendedSpringConvocation { get; set; }
        public bool? AttendedCommencement { get; set; }
        public bool? AttendedFallConvocation { get; set; }

        public virtual Services S { get; set; }
    }
}
