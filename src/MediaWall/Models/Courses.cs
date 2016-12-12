using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Courses
    {
        public Courses()
        {
            FacultyCourse = new HashSet<FacultyCourse>();
        }

        public int Cid { get; set; }
        public string Term { get; set; }
        public string Crn { get; set; }
        public string CourseSubject { get; set; }
        public string Number { get; set; }
        public string Title { get; set; }
        public string CourseDescription { get; set; }
        public int? CourseYear { get; set; }
        public int? Section { get; set; }
        public double? CreditHoursLow { get; set; }
        public double? CreditHoursHigh { get; set; }
        public double? LectureHours { get; set; }
        public double? ClinicalHours { get; set; }
        public double? LabHours { get; set; }
        public int? NumberOfStudents { get; set; }
        public bool? IsIntensive { get; set; }

        public virtual ICollection<FacultyCourse> FacultyCourse { get; set; }
        public virtual Termlookup TermNavigation { get; set; }
    }
}
