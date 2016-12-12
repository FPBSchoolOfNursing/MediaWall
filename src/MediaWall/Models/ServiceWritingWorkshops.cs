using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ServiceWritingWorkshops
    {
        public int Swwid { get; set; }
        public int? Sid { get; set; }
        public bool? May { get; set; }
        public bool? September { get; set; }
        public bool? December { get; set; }

        public virtual Services S { get; set; }
    }
}
