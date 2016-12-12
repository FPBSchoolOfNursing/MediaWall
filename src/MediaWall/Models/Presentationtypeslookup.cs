using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Presentationtypeslookup
    {
        public Presentationtypeslookup()
        {
            ObsoletePresentations = new HashSet<ObsoletePresentations>();
            Presentations = new HashSet<Presentations>();
        }

        public string PresentationType { get; set; }

        public virtual ICollection<ObsoletePresentations> ObsoletePresentations { get; set; }
        public virtual ICollection<Presentations> Presentations { get; set; }
    }
}
