using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class GroupOffice
    {
        public int GroupId { get; set; }
        public string OfficeNum { get; set; }

        public virtual Groups Group { get; set; }
        public virtual Office OfficeNumNavigation { get; set; }
    }
}
