using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class StudentAdvisees
    {
        public int Sid { get; set; }
        public int? Arptid { get; set; }
        public string ProgramName { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string OtherExplain { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Arpt Arpt { get; set; }
        public virtual Programlookup ProgramNameNavigation { get; set; }
    }
}
