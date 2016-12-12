using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class NewCourseDevelopment
    {
        public int Ncdid { get; set; }
        public int? Arptid { get; set; }
        public string Description { get; set; }

        public virtual Arpt Arpt { get; set; }
    }
}
