using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class ObsoletePresentations
    {
        public ObsoletePresentations()
        {
            ObsoletePresentationsAuthors = new HashSet<ObsoletePresentationsAuthors>();
        }

        public int Prid { get; set; }
        public int? Arptid { get; set; }
        public string PresentationType { get; set; }
        public string Title { get; set; }
        public string Conference { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PresentationDate { get; set; }
        public string FullCitation { get; set; }
        public bool? IsRefereed { get; set; }
        public bool? IsInvited { get; set; }

        public virtual ICollection<ObsoletePresentationsAuthors> ObsoletePresentationsAuthors { get; set; }
        public virtual Arpt Arpt { get; set; }
        public virtual Presentationtypeslookup PresentationTypeNavigation { get; set; }
    }
}
