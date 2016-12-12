using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class PersonToPublications
    {
        public int PublicationId { get; set; }
        public string CaseUserId { get; set; }

        public virtual Person CaseUser { get; set; }
        public virtual Publications Publication { get; set; }
    }
}
