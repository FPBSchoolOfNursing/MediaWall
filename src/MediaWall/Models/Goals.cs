using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Goals
    {
        public int Gid { get; set; }
        public int? Arptid { get; set; }
        public string Teaching { get; set; }
        public string Research { get; set; }
        public string Comittee { get; set; }
        public string Mentor { get; set; }
        public string Community { get; set; }
        public string Training { get; set; }
        public string Scholarship { get; set; }
        public string Personal { get; set; }
        public bool? IsCurrent { get; set; }

        public virtual Arpt Arpt { get; set; }
    }
}
