using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Person
    {
        public Person()
        {
            Absences = new HashSet<Absences>();
            Addresses = new HashSet<Addresses>();
            Degree = new HashSet<Degree>();
            EmergencyContact = new HashSet<EmergencyContact>();
            Ethnicity = new HashSet<Ethnicity>();
            PersonCredentials = new HashSet<PersonCredentials>();
            PersonGroup = new HashSet<PersonGroup>();
            PersonOffice = new HashSet<PersonOffice>();
            PersonToPresentations = new HashSet<PersonToPresentations>();
            PersonToPublications = new HashSet<PersonToPublications>();
        }

        public string CaseUserId { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string PreferredName { get; set; }
        public string Phone { get; set; }
        public string ProfileLink { get; set; }
        public string PictureLink { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string EmplId { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public string CellPhone { get; set; }
        public string Pager { get; set; }
        public string OtherEmail { get; set; }
        public string PersonStatus { get; set; }
        public string PersonType { get; set; }
        public int PersonId { get; set; }
        public string FacultyId { get; set; }
        public DateTime? Dmdate { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Dmid { get; set; }

        public virtual ICollection<Absences> Absences { get; set; }
        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<Degree> Degree { get; set; }
        public virtual ICollection<EmergencyContact> EmergencyContact { get; set; }
        public virtual ICollection<Ethnicity> Ethnicity { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<PersonCredentials> PersonCredentials { get; set; }
        public virtual ICollection<PersonGroup> PersonGroup { get; set; }
        public virtual ICollection<PersonOffice> PersonOffice { get; set; }
        public virtual ICollection<PersonToPresentations> PersonToPresentations { get; set; }
        public virtual ICollection<PersonToPublications> PersonToPublications { get; set; }
    }
}
