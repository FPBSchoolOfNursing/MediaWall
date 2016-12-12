using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class CourseSection
    {
        public CourseSection()
        {
            Assignments = new HashSet<Assignments>();
        }

        public int SectionId { get; set; }
        public int CourseId { get; set; }
        public int? Crn { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string DaysTaught { get; set; }
        public string DeliveryMethod { get; set; }
        public string CourseType { get; set; }
        public string SectionNumber { get; set; }
        public bool? IsIntensive { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<Assignments> Assignments { get; set; }
        public virtual Course Course { get; set; }
    }
}
