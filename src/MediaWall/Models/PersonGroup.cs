using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class PersonGroup
    {
        public string CaseUserId { get; set; }
        public int GroupId { get; set; }

        public virtual Person CaseUser { get; set; }
        public virtual Groups Group { get; set; }
    }
}
