using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class CourseTerms
    {
        public CourseTerms()
        {
            Course = new HashSet<Course>();
        }

        public string TermCode { get; set; }
        public string Term { get; set; }
        public int Year { get; set; }
        public int? AcademicYear { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}
