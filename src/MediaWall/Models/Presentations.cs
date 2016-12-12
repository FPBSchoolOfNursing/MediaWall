using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Presentations
    {
        public Presentations()
        {
            PersonToPresentations = new HashSet<PersonToPresentations>();
            PresentationsAuthors = new HashSet<PresentationsAuthors>();
        }

        public int PresentationId { get; set; }
        public string PresentationType { get; set; }
        public string FullCitation { get; set; }
        public string Title { get; set; }
        public string Conference { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime? PresentationDate { get; set; }
        public bool? IsRefereed { get; set; }
        public bool? IsInvited { get; set; }
        public string SponsoringOrg { get; set; }
        public string Location { get; set; }
        public string MeetingType { get; set; }
        public string Scope { get; set; }
        public bool? IsPublishedProceedings { get; set; }
        public bool? IsPublishedElsewhere { get; set; }
        public bool? IsAccepted { get; set; }
        public string Abstract { get; set; }
        public string FileLocation { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual ICollection<PersonToPresentations> PersonToPresentations { get; set; }
        public virtual ICollection<PresentationsAuthors> PresentationsAuthors { get; set; }
        public virtual Presentationtypeslookup PresentationTypeNavigation { get; set; }
    }
}
