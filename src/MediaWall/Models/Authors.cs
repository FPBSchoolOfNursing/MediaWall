using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Authors
    {
        public Authors()
        {
            PresentationsAuthors = new HashSet<PresentationsAuthors>();
            PublicationsAuthors = new HashSet<PublicationsAuthors>();
        }

        public int AuthorId { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public string FName { get; set; }
        public string FacultyId { get; set; }

        public virtual ICollection<PresentationsAuthors> PresentationsAuthors { get; set; }
        public virtual ICollection<PublicationsAuthors> PublicationsAuthors { get; set; }
    }
}
