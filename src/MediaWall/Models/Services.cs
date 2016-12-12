using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Services
    {
        public Services()
        {
            AlumniActivities = new HashSet<AlumniActivities>();
            FacultyMeetingAttendance = new HashSet<FacultyMeetingAttendance>();
            FacultyMeetingAttendance1 = new HashSet<FacultyMeetingAttendance1>();
            RecruitmentActivities = new HashSet<RecruitmentActivities>();
            ServiceAttendance = new HashSet<ServiceAttendance>();
            ServiceCommittees = new HashSet<ServiceCommittees>();
            ServiceWritingWorkshops = new HashSet<ServiceWritingWorkshops>();
        }

        public int Sid { get; set; }
        public int? Arptid { get; set; }
        public string UnivOther { get; set; }
        public string SchoolOther { get; set; }
        public string ProfessionOther { get; set; }
        public string CommunityOther { get; set; }
        public bool? IsCommencement { get; set; }
        public bool? IsRetreat { get; set; }
        public string AdministrativeRoles { get; set; }

        public virtual ICollection<AlumniActivities> AlumniActivities { get; set; }
        public virtual ICollection<FacultyMeetingAttendance> FacultyMeetingAttendance { get; set; }
        public virtual ICollection<FacultyMeetingAttendance1> FacultyMeetingAttendance1 { get; set; }
        public virtual ICollection<RecruitmentActivities> RecruitmentActivities { get; set; }
        public virtual ICollection<ServiceAttendance> ServiceAttendance { get; set; }
        public virtual ICollection<ServiceCommittees> ServiceCommittees { get; set; }
        public virtual ICollection<ServiceWritingWorkshops> ServiceWritingWorkshops { get; set; }
        public virtual Arpt Arpt { get; set; }
    }
}
