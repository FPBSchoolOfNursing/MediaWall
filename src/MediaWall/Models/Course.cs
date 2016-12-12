using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseSection = new HashSet<CourseSection>();
        }

        public int CourseId { get; set; }
        public string TermCode { get; set; }
        public string Prefix { get; set; }
        public string Number { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Chlow { get; set; }
        public decimal? Chhigh { get; set; }
        public decimal? LectureHrs { get; set; }
        public decimal? ClinicalHrs { get; set; }
        public decimal? LabHrs { get; set; }
        public decimal? CoorHrs { get; set; }
        public decimal? PracHrs { get; set; }
        public decimal? SemHrs { get; set; }
        public decimal? ResearchHrs { get; set; }
        public string Syllabus { get; set; }
        public string Program { get; set; }

        public virtual ICollection<CourseSection> CourseSection { get; set; }
        public virtual CourseTerms TermCodeNavigation { get; set; }
    }
}
