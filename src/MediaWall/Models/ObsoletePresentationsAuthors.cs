using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ObsoletePresentationsAuthors
    {
        public int Prid { get; set; }
        public int Aid { get; set; }

        public virtual ObsoleteAuthors A { get; set; }
        public virtual ObsoletePresentations Pr { get; set; }
    }
}
