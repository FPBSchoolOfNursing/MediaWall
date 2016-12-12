using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class AlumniActivities
    {
        public int Aaid { get; set; }
        public int? Sid { get; set; }
        public string Activity { get; set; }
        public string PersonRole { get; set; }

        public virtual Services S { get; set; }
    }
}
