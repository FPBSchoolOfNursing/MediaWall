using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Absences
    {
        public int Aid { get; set; }
        public string Duration { get; set; }
        public string Reason { get; set; }
        public string CaseUserId { get; set; }
        public DateTime AbsentDate { get; set; }
        public DateTime AbsentEntryDate { get; set; }
        public string ReasonNotes { get; set; }

        public virtual Person CaseUser { get; set; }
        public virtual AbsentDurationLookup DurationNavigation { get; set; }
        public virtual AbsentReasonLookup ReasonNavigation { get; set; }
    }
}
