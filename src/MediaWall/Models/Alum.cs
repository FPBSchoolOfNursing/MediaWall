using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Alum
    {
        public int Aid { get; set; }
        public int Pid { get; set; }
        public int? Cid { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }
        public string Fname { get; set; }
        public string Maidenname { get; set; }
        public DateTime? Photodate { get; set; }
        public DateTime? Graddate { get; set; }
        public string Biography { get; set; }
        public bool IsDistinguished { get; set; }

        public virtual Class C { get; set; }
        public virtual Pictures P { get; set; }
    }
}
