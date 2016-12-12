using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Publicationstatuslookup
    {
        public Publicationstatuslookup()
        {
            ObsoletePublications = new HashSet<ObsoletePublications>();
            Publications = new HashSet<Publications>();
        }

        public string PublicationStatus { get; set; }

        public virtual ICollection<ObsoletePublications> ObsoletePublications { get; set; }
        public virtual ICollection<Publications> Publications { get; set; }
    }
}
