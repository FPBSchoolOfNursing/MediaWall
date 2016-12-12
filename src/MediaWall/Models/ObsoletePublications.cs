using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ObsoletePublications
    {
        public ObsoletePublications()
        {
            ObsoletePublicationsAuthors = new HashSet<ObsoletePublicationsAuthors>();
        }

        public int Puid { get; set; }
        public int? Arptid { get; set; }
        public string PublicationStatus { get; set; }
        public string PublicationType { get; set; }
        public string FullCitation { get; set; }
        public string Title { get; set; }
        public bool? IsPeerReviewed { get; set; }
        public bool? IsDatabased { get; set; }
        public bool? IsStudentCoAuthored { get; set; }
        public int? PublishedYear { get; set; }

        public virtual ObsoleteBook ObsoleteBook { get; set; }
        public virtual ObsoleteJournal ObsoleteJournal { get; set; }
        public virtual ICollection<ObsoletePublicationsAuthors> ObsoletePublicationsAuthors { get; set; }
        public virtual ObsoleteWeb ObsoleteWeb { get; set; }
        public virtual Arpt Arpt { get; set; }
        public virtual Publicationstatuslookup PublicationStatusNavigation { get; set; }
        public virtual Publicationtypeslookup PublicationTypeNavigation { get; set; }
    }
}
