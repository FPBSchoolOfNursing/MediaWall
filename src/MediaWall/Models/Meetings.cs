using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Meetings
    {
        public Meetings()
        {
            MeetingAttendence = new HashSet<MeetingAttendence>();
            MeetingNotes = new HashSet<MeetingNotes>();
        }

        public int MeetingId { get; set; }
        public string MeetingType { get; set; }
        public string MeetingSubject { get; set; }
        public string Location { get; set; }
        public DateTime? MeetingStartDate { get; set; }
        public DateTime? MeetingEndDate { get; set; }
        public string OtherExplain { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual ICollection<MeetingAttendence> MeetingAttendence { get; set; }
        public virtual ICollection<MeetingNotes> MeetingNotes { get; set; }
    }
}
