using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Mentors
    {
        public int Mid { get; set; }
        public string MentorId { get; set; }
        public int? Arptid { get; set; }
        public string Activity { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Comment { get; set; }
        public string CommunicationFreq { get; set; }
        public string MentorType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Arpt Arpt { get; set; }
        public virtual Faculty Mentor { get; set; }
    }
}
