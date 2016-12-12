using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class PersonToPresentations
    {
        public int PresentationId { get; set; }
        public string CaseUserId { get; set; }

        public virtual Person CaseUser { get; set; }
        public virtual Presentations Presentation { get; set; }
    }
}
