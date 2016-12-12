using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Programlookup
    {
        public Programlookup()
        {
            StudentAdvisees = new HashSet<StudentAdvisees>();
        }

        public string ProgramName { get; set; }

        public virtual ICollection<StudentAdvisees> StudentAdvisees { get; set; }
    }
}
