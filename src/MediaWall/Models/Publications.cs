using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Publications
    {
        public Publications()
        {
            PersonToPublications = new HashSet<PersonToPublications>();
            PublicationsAuthors = new HashSet<PublicationsAuthors>();
        }

        public int PublicationId { get; set; }
        public string PublicationType { get; set; }
        public string PublicationStatus { get; set; }
        public string FullCitation { get; set; }
        public int? PublishedYear { get; set; }
        public bool? IsPeerReviewed { get; set; }
        public bool? IsDatabased { get; set; }
        public bool? IsStudentCoAuthored { get; set; }
        public bool? IsRefereed { get; set; }
        public bool? IsPublic { get; set; }
        public string PubMedId { get; set; }
        public string Abstract { get; set; }
        public string FileLocation { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public DateTime? InPressDate { get; set; }
        public DateTime? EpublishedDate { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string Audience { get; set; }
        public string Editors { get; set; }
        public string Title { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Journal Journal { get; set; }
        public virtual ICollection<PersonToPublications> PersonToPublications { get; set; }
        public virtual ICollection<PublicationsAuthors> PublicationsAuthors { get; set; }
        public virtual Web Web { get; set; }
        public virtual Publicationstatuslookup PublicationStatusNavigation { get; set; }
    }
}
