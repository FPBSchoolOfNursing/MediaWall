using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Class
    {
        public Class()
        {
            Alum = new HashSet<Alum>();
        }

        public int Cid { get; set; }
        public int? Pid { get; set; }
        public string Program { get; set; }
        public string Term { get; set; }
        public int Year { get; set; }

        public virtual ICollection<Alum> Alum { get; set; }
        public virtual Pictures P { get; set; }
    }
}
