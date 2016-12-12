using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Groups
    {
        public Groups()
        {
            GroupOffice = new HashSet<GroupOffice>();
            PersonGroup = new HashSet<PersonGroup>();
        }

        public int GroupId { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public bool? IsGrant { get; set; }
        public bool IsDm { get; set; }

        public virtual ICollection<GroupOffice> GroupOffice { get; set; }
        public virtual ICollection<PersonGroup> PersonGroup { get; set; }
    }
}
