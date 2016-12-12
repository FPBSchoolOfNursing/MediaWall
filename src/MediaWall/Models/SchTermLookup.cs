using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class SchTermLookup
    {
        public SchTermLookup()
        {
            SchTeach = new HashSet<SchTeach>();
        }

        public string Term { get; set; }

        public virtual ICollection<SchTeach> SchTeach { get; set; }
    }
}
