using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class MeetingNotes
    {
        public int Mnid { get; set; }
        public int? MeetingId { get; set; }
        public string NotesLocation { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string Dmid { get; set; }

        public virtual Meetings Meeting { get; set; }
    }
}
