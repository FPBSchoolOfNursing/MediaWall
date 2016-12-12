using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class GuestLectures
    {
        public int Gid { get; set; }
        public int? Arptid { get; set; }
        public string Course { get; set; }
        public string Topic { get; set; }
        public double ClassHours { get; set; }

        public virtual Arpt Arpt { get; set; }
    }
}
