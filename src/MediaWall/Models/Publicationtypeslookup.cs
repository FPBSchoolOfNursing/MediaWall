using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Publicationtypeslookup
    {
        public Publicationtypeslookup()
        {
            ObsoletePublications = new HashSet<ObsoletePublications>();
        }

        public string PublicationType { get; set; }

        public virtual ICollection<ObsoletePublications> ObsoletePublications { get; set; }
    }
}
