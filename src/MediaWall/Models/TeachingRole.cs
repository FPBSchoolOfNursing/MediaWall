using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class TeachingRole
    {
        public TeachingRole()
        {
            Assignments = new HashSet<Assignments>();
        }

        public string TeachingRole1 { get; set; }

        public virtual ICollection<Assignments> Assignments { get; set; }
    }
}
