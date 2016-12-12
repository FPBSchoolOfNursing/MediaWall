using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            Activities = new HashSet<Activities>();
            AdminAppointments = new HashSet<AdminAppointments>();
            Arpt = new HashSet<Arpt>();
            Assignments = new HashSet<Assignments>();
            Committees = new HashSet<Committees>();
            DoctoralCommittees = new HashSet<DoctoralCommittees>();
            FacultyCourse = new HashSet<FacultyCourse>();
            FacultySchTeach = new HashSet<FacultySchTeach>();
            FileRepository = new HashSet<FileRepository>();
            Goals1 = new HashSet<Goals1>();
            Honors = new HashSet<Honors>();
            MeetingAttendence = new HashSet<MeetingAttendence>();
            Mentors = new HashSet<Mentors>();
            NonCreditInstruction = new HashSet<NonCreditInstruction>();
            Ranks = new HashSet<Ranks>();
            RanksOld = new HashSet<RanksOld>();
            Roles = new HashSet<Roles>();
            Specialties = new HashSet<Specialties>();
            Title = new HashSet<Title>();
            Utilization = new HashSet<Utilization>();
            Utilization1 = new HashSet<Utilization1>();
        }

        public string CaseUserId { get; set; }
        public DateTime? TenureDate { get; set; }
        public string TenureConsideredDate { get; set; }
        public string EraUserName { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string TenureStatus { get; set; }

        public virtual ICollection<Activities> Activities { get; set; }
        public virtual ICollection<AdminAppointments> AdminAppointments { get; set; }
        public virtual ICollection<Arpt> Arpt { get; set; }
        public virtual ICollection<Assignments> Assignments { get; set; }
        public virtual ICollection<Committees> Committees { get; set; }
        public virtual ICollection<DoctoralCommittees> DoctoralCommittees { get; set; }
        public virtual ICollection<FacultyCourse> FacultyCourse { get; set; }
        public virtual ICollection<FacultySchTeach> FacultySchTeach { get; set; }
        public virtual ICollection<FileRepository> FileRepository { get; set; }
        public virtual ICollection<Goals1> Goals1 { get; set; }
        public virtual ICollection<Honors> Honors { get; set; }
        public virtual ICollection<MeetingAttendence> MeetingAttendence { get; set; }
        public virtual ICollection<Mentors> Mentors { get; set; }
        public virtual ICollection<NonCreditInstruction> NonCreditInstruction { get; set; }
        public virtual NonTenureFoci NonTenureFoci { get; set; }
        public virtual ICollection<Ranks> Ranks { get; set; }
        public virtual ICollection<RanksOld> RanksOld { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<Specialties> Specialties { get; set; }
        public virtual ICollection<Title> Title { get; set; }
        public virtual ICollection<Utilization> Utilization { get; set; }
        public virtual ICollection<Utilization1> Utilization1 { get; set; }
        public virtual Person CaseUser { get; set; }
        public virtual Tenurelookup TenureStatusNavigation { get; set; }
    }
}
