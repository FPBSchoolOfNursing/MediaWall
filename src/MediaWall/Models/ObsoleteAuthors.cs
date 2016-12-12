using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ObsoleteAuthors
    {
        public ObsoleteAuthors()
        {
            ObsoletePresentationsAuthors = new HashSet<ObsoletePresentationsAuthors>();
            ObsoletePublicationsAuthors = new HashSet<ObsoletePublicationsAuthors>();
        }

        public int Aid { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public string FName { get; set; }

        public virtual ICollection<ObsoletePresentationsAuthors> ObsoletePresentationsAuthors { get; set; }
        public virtual ICollection<ObsoletePublicationsAuthors> ObsoletePublicationsAuthors { get; set; }
    }
}
