using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class SchTeach
    {
        public SchTeach()
        {
            FacultySchTeach = new HashSet<FacultySchTeach>();
            SchTeachStudents = new HashSet<SchTeachStudents>();
        }

        public string Dmid { get; set; }
        public string Term { get; set; }
        public int TermYear { get; set; }
        public string CourseName { get; set; }
        public string CoursePrefix { get; set; }
        public int CourseNumber { get; set; }
        public decimal? CreditHours { get; set; }
        public int? EnrollmentNumber { get; set; }
        public string IndependentStudyTopic { get; set; }
        public string Division { get; set; }
        public string CourseLevel { get; set; }
        public string DeliveryMode { get; set; }
        public bool? IsNewCoursePrep { get; set; }
        public bool? IsNewFormat { get; set; }
        public string Innovations { get; set; }
        public string NewTeachingMaterial { get; set; }
        public string Activities { get; set; }
        public string SyllabusLocation { get; set; }
        public DateTime? Dmdate { get; set; }
        public string CrossListing { get; set; }
        public string OtherExplain { get; set; }

        public virtual ICollection<FacultySchTeach> FacultySchTeach { get; set; }
        public virtual ICollection<SchTeachStudents> SchTeachStudents { get; set; }
        public virtual SchTermLookup TermNavigation { get; set; }
    }
}
