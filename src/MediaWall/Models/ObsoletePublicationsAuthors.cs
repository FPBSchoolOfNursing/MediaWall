using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ObsoletePublicationsAuthors
    {
        public int Puid { get; set; }
        public int Aid { get; set; }

        public virtual ObsoleteAuthors A { get; set; }
        public virtual ObsoletePublications Pu { get; set; }
    }
}
