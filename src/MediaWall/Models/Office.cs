using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Office
    {
        public Office()
        {
            GroupOffice = new HashSet<GroupOffice>();
            PersonOffice = new HashSet<PersonOffice>();
        }

        public string OfficeNum { get; set; }
        public string Location { get; set; }
        public int? SqFt { get; set; }

        public virtual ICollection<GroupOffice> GroupOffice { get; set; }
        public virtual ICollection<PersonOffice> PersonOffice { get; set; }
    }
}
