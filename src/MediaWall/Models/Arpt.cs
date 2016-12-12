using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Arpt
    {
        public Arpt()
        {
            AdditionalInformation = new HashSet<AdditionalInformation>();
            ArptreadOnlyErrors = new HashSet<ArptreadOnlyErrors>();
            CandidacyCommittees = new HashSet<CandidacyCommittees>();
            DoctoralCommittees1 = new HashSet<DoctoralCommittees1>();
            FileRepository = new HashSet<FileRepository>();
            Goals = new HashSet<Goals>();
            GuestLectures = new HashSet<GuestLectures>();
            Honors = new HashSet<Honors>();
            IndependentStudies = new HashSet<IndependentStudies>();
            Mentors = new HashSet<Mentors>();
            NewCourseDevelopment = new HashSet<NewCourseDevelopment>();
            ObsoletePresentations = new HashSet<ObsoletePresentations>();
            ObsoletePublications = new HashSet<ObsoletePublications>();
            OtherResearch = new HashSet<OtherResearch>();
            Services = new HashSet<Services>();
            StudentAdvisees = new HashSet<StudentAdvisees>();
        }

        public int Arptid { get; set; }
        public string CaseUserId { get; set; }
        public DateTime Arptdate { get; set; }
        public int Arptterm { get; set; }
        public bool Migrated { get; set; }

        public virtual ICollection<AdditionalInformation> AdditionalInformation { get; set; }
        public virtual ICollection<ArptreadOnlyErrors> ArptreadOnlyErrors { get; set; }
        public virtual ICollection<CandidacyCommittees> CandidacyCommittees { get; set; }
        public virtual ICollection<DoctoralCommittees1> DoctoralCommittees1 { get; set; }
        public virtual ICollection<FileRepository> FileRepository { get; set; }
        public virtual ICollection<Goals> Goals { get; set; }
        public virtual ICollection<GuestLectures> GuestLectures { get; set; }
        public virtual ICollection<Honors> Honors { get; set; }
        public virtual ICollection<IndependentStudies> IndependentStudies { get; set; }
        public virtual ICollection<Mentors> Mentors { get; set; }
        public virtual ICollection<NewCourseDevelopment> NewCourseDevelopment { get; set; }
        public virtual ICollection<ObsoletePresentations> ObsoletePresentations { get; set; }
        public virtual ICollection<ObsoletePublications> ObsoletePublications { get; set; }
        public virtual ICollection<OtherResearch> OtherResearch { get; set; }
        public virtual ICollection<Services> Services { get; set; }
        public virtual ICollection<StudentAdvisees> StudentAdvisees { get; set; }
        public virtual Faculty CaseUser { get; set; }
    }
}
