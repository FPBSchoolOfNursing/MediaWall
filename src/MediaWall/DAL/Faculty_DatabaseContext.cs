using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MediaWall.Models
{
    public partial class Faculty_DatabaseContext : DbContext
    {
        public virtual DbSet<Absences> Absences { get; set; }
        public virtual DbSet<AbsentDurationLookup> AbsentDurationLookup { get; set; }
        public virtual DbSet<AbsentReasonLookup> AbsentReasonLookup { get; set; }
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<AdditionalInformation> AdditionalInformation { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Addresslookup> Addresslookup { get; set; }
        public virtual DbSet<AdminAppointments> AdminAppointments { get; set; }
        public virtual DbSet<AlumniActivities> AlumniActivities { get; set; }
        public virtual DbSet<Arpt> Arpt { get; set; }
        public virtual DbSet<ArptreadOnlyErrors> ArptreadOnlyErrors { get; set; }
        public virtual DbSet<Assignments> Assignments { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<CandidacyCommittees> CandidacyCommittees { get; set; }
        public virtual DbSet<Committees> Committees { get; set; }
        public virtual DbSet<CommitteesLookup> CommitteesLookup { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseSection> CourseSection { get; set; }
        public virtual DbSet<CourseTerms> CourseTerms { get; set; }
        public virtual DbSet<CourseXlist> CourseXlist { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Credentialslookup> Credentialslookup { get; set; }
        public virtual DbSet<Degree> Degree { get; set; }
        public virtual DbSet<DoctoralCommittees> DoctoralCommittees { get; set; }
        public virtual DbSet<DoctoralCommittees1> DoctoralCommittees1 { get; set; }
        public virtual DbSet<Doctoralcommitteeslocalelookup> Doctoralcommitteeslocalelookup { get; set; }
        public virtual DbSet<Doctoralcommitteeslookup> Doctoralcommitteeslookup { get; set; }
        public virtual DbSet<EmergencyContact> EmergencyContact { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Ethnicity> Ethnicity { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<FacultyCourse> FacultyCourse { get; set; }
        public virtual DbSet<FacultyMeetingAttendance> FacultyMeetingAttendance { get; set; }
        public virtual DbSet<FacultyMeetingAttendance1> FacultyMeetingAttendance1 { get; set; }
        public virtual DbSet<FacultySchTeach> FacultySchTeach { get; set; }
        public virtual DbSet<FileRepository> FileRepository { get; set; }
        public virtual DbSet<Goals> Goals { get; set; }
        public virtual DbSet<Goals1> Goals1 { get; set; }
        public virtual DbSet<GroupOffice> GroupOffice { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<GuestLectures> GuestLectures { get; set; }
        public virtual DbSet<Honors> Honors { get; set; }
        public virtual DbSet<IndependentStudies> IndependentStudies { get; set; }
        public virtual DbSet<Journal> Journal { get; set; }
        public virtual DbSet<MeetingAttendence> MeetingAttendence { get; set; }
        public virtual DbSet<MeetingNotes> MeetingNotes { get; set; }
        public virtual DbSet<Meetings> Meetings { get; set; }
        public virtual DbSet<Mentors> Mentors { get; set; }
        public virtual DbSet<NewCourseDevelopment> NewCourseDevelopment { get; set; }
        public virtual DbSet<Nominators> Nominators { get; set; }
        public virtual DbSet<NonCreditInstruction> NonCreditInstruction { get; set; }
        public virtual DbSet<NonTenureFoci> NonTenureFoci { get; set; }
        public virtual DbSet<Noncreditinstructionlookup> Noncreditinstructionlookup { get; set; }
        public virtual DbSet<ObsoleteAuthors> ObsoleteAuthors { get; set; }
        public virtual DbSet<ObsoleteBook> ObsoleteBook { get; set; }
        public virtual DbSet<ObsoleteJournal> ObsoleteJournal { get; set; }
        public virtual DbSet<ObsoletePresentations> ObsoletePresentations { get; set; }
        public virtual DbSet<ObsoletePresentationsAuthors> ObsoletePresentationsAuthors { get; set; }
        public virtual DbSet<ObsoletePublications> ObsoletePublications { get; set; }
        public virtual DbSet<ObsoletePublicationsAuthors> ObsoletePublicationsAuthors { get; set; }
        public virtual DbSet<ObsoleteWeb> ObsoleteWeb { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<OtherResearch> OtherResearch { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonCredentials> PersonCredentials { get; set; }
        public virtual DbSet<PersonGroup> PersonGroup { get; set; }
        public virtual DbSet<PersonOffice> PersonOffice { get; set; }
        public virtual DbSet<PersonToPresentations> PersonToPresentations { get; set; }
        public virtual DbSet<PersonToPublications> PersonToPublications { get; set; }
        public virtual DbSet<Persontypeslookup> Persontypeslookup { get; set; }
        public virtual DbSet<Presentations> Presentations { get; set; }
        public virtual DbSet<PresentationsAuthors> PresentationsAuthors { get; set; }
        public virtual DbSet<Presentationtypeslookup> Presentationtypeslookup { get; set; }
        public virtual DbSet<Programlookup> Programlookup { get; set; }
        public virtual DbSet<Publications> Publications { get; set; }
        public virtual DbSet<PublicationsAuthors> PublicationsAuthors { get; set; }
        public virtual DbSet<Publicationstatuslookup> Publicationstatuslookup { get; set; }
        public virtual DbSet<Publicationtypeslookup> Publicationtypeslookup { get; set; }
        public virtual DbSet<Ranklookup> Ranklookup { get; set; }
        public virtual DbSet<Ranks> Ranks { get; set; }
        public virtual DbSet<RanksOld> RanksOld { get; set; }
        public virtual DbSet<RecruitmentActivities> RecruitmentActivities { get; set; }
        public virtual DbSet<Rolelookup> Rolelookup { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SchRoleLookup> SchRoleLookup { get; set; }
        public virtual DbSet<SchTeach> SchTeach { get; set; }
        public virtual DbSet<SchTeachStudents> SchTeachStudents { get; set; }
        public virtual DbSet<SchTermLookup> SchTermLookup { get; set; }
        public virtual DbSet<ServiceAttendance> ServiceAttendance { get; set; }
        public virtual DbSet<ServiceCommittees> ServiceCommittees { get; set; }
        public virtual DbSet<ServiceWritingWorkshops> ServiceWritingWorkshops { get; set; }
        public virtual DbSet<Servicecommitteetypeslookup> Servicecommitteetypeslookup { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Specialties> Specialties { get; set; }
        public virtual DbSet<Statuslookup> Statuslookup { get; set; }
        public virtual DbSet<StudentAdvisees> StudentAdvisees { get; set; }
        public virtual DbSet<TeachingRole> TeachingRole { get; set; }
        public virtual DbSet<Tenurelookup> Tenurelookup { get; set; }
        public virtual DbSet<Termlookup> Termlookup { get; set; }
        public virtual DbSet<Title> Title { get; set; }
        public virtual DbSet<Titlelookup> Titlelookup { get; set; }
        public virtual DbSet<Utilization> Utilization { get; set; }
        public virtual DbSet<Utilization1> Utilization1 { get; set; }
        public virtual DbSet<Web> Web { get; set; }

        // Unable to generate entity type for table 'Faculty.CommitteesBackUp'. Please see the warning messages.
        // Unable to generate entity type for table 'DM.INTELLCONT'. Please see the warning messages.
        // Unable to generate entity type for table 'Obsolete.OldRanks'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UtilTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'Publications.PresentationsBackup22011'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=hawkeye-v.case.edu, 31338;Initial Catalog=Faculty Database;User ID=Telephone_Directory_Web;Password=Dodocaca peepee!");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Absences>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PK_Person.Absences");

                entity.ToTable("Absences", "Person");

                entity.Property(e => e.Aid).HasColumnName("AID");

                entity.Property(e => e.AbsentDate).HasColumnType("datetime");

                entity.Property(e => e.AbsentEntryDate).HasColumnType("datetime");

                entity.Property(e => e.CaseUserId)
                    .IsRequired()
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasColumnType("varchar(42)");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnType("varchar(42)");

                entity.Property(e => e.ReasonNotes).HasColumnType("varchar(max)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Absences)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Absences_Person");

                entity.HasOne(d => d.DurationNavigation)
                    .WithMany(p => p.Absences)
                    .HasForeignKey(d => d.Duration)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Absences_AbsentDurationLookup");

                entity.HasOne(d => d.ReasonNavigation)
                    .WithMany(p => p.Absences)
                    .HasForeignKey(d => d.Reason)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Absences_AbsentReasonLookup");
            });

            modelBuilder.Entity<AbsentDurationLookup>(entity =>
            {
                entity.HasKey(e => e.Duration)
                    .HasName("PK_AbsentDurationLookup");

                entity.ToTable("AbsentDurationLookup", "Person");

                entity.Property(e => e.Duration).HasColumnType("varchar(42)");
            });

            modelBuilder.Entity<AbsentReasonLookup>(entity =>
            {
                entity.HasKey(e => e.Reason)
                    .HasName("PK_AbsentReasonLookup");

                entity.ToTable("AbsentReasonLookup", "Person");

                entity.Property(e => e.Reason).HasColumnType("varchar(42)");
            });

            modelBuilder.Entity<Activities>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK__Activities__6F47858F");

                entity.ToTable("Activities", "Faculty");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.ActivityType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CaseUserId)
                    .IsRequired()
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.CreditHours).HasMaxLength(10);

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GroupName).HasMaxLength(500);

                entity.Property(e => e.IsInternational).HasColumnName("isInternational");

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.PersonRole).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Activitie__CaseU__703BA9C8");
            });

            modelBuilder.Entity<AdditionalInformation>(entity =>
            {
                entity.HasKey(e => e.Aiid)
                    .HasName("PK__AdditionalInform__01FA6750");

                entity.ToTable("AdditionalInformation", "ARPT");

                entity.Property(e => e.Aiid).HasColumnName("AIID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.ExtraInfo).HasColumnType("varchar(max)");

                entity.Property(e => e.GoalAssist).HasColumnType("varchar(max)");

                entity.Property(e => e.OtherComments).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.AdditionalInformation)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__Additiona__ARPTI__6F919E52");
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.AddrId)
                    .HasName("PK__Addresses__461A8773");

                entity.ToTable("Addresses", "Person");

                entity.Property(e => e.AddrId).HasColumnName("AddrID");

                entity.Property(e => e.AddrType).HasColumnType("varchar(10)");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Address2).HasColumnType("varchar(255)");

                entity.Property(e => e.Address3).HasColumnType("varchar(255)");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.Fax).HasColumnType("varchar(14)");

                entity.Property(e => e.IsMailable).HasColumnName("isMailable");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.Phone2).HasColumnType("varchar(14)");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnType("varchar(15)");

                entity.HasOne(d => d.AddrTypeNavigation)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddrType)
                    .HasConstraintName("FK__Addresses__AddrT__628CA8EF");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Addresses__CaseU__470EABAC");
            });

            modelBuilder.Entity<Addresslookup>(entity =>
            {
                entity.HasKey(e => e.AddrType)
                    .HasName("PK__ADDRESSLOOKUP__44323F01");

                entity.ToTable("ADDRESSLOOKUP", "Person");

                entity.Property(e => e.AddrType).HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<AdminAppointments>(entity =>
            {
                entity.HasKey(e => e.AdminTitleId)
                    .HasName("PK__AdminAppointment__60F96638");

                entity.ToTable("AdminAppointments", "Faculty");

                entity.Property(e => e.AdminTitleId).HasColumnName("AdminTitleID");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.TitleDesc).HasColumnType("text");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.AdminAppointments)
                    .HasForeignKey(d => d.CaseUserId)
                    .HasConstraintName("FK__AdminAppo__CaseU__61ED8A71");
            });

            modelBuilder.Entity<AlumniActivities>(entity =>
            {
                entity.HasKey(e => e.Aaid)
                    .HasName("PK__AlumniActivities__50630BBC");

                entity.ToTable("AlumniActivities", "Obsolete");

                entity.Property(e => e.Aaid).HasColumnName("AAID");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.PersonRole)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.AlumniActivities)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__AlumniActiv__SID__51572FF5");
            });

            modelBuilder.Entity<Arpt>(entity =>
            {
                entity.ToTable("ARPT", "ARPT");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.Arptdate)
                    .HasColumnName("ARPTDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Arptterm).HasColumnName("ARPTTerm");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Arpt)
                    .HasForeignKey(d => d.CaseUserId)
                    .HasConstraintName("FK__ARPT__CaseUserID__1CE367B6");
            });

            modelBuilder.Entity<ArptreadOnlyErrors>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__ARPTReadOnlyErro__718EF55D");

                entity.ToTable("ARPTReadOnlyErrors", "ARPT");

                entity.Property(e => e.Eid).HasColumnName("EID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.Error).HasColumnType("varchar(max)");

                entity.Property(e => e.IsFixed).HasColumnName("isFixed");

                entity.Property(e => e.Section).HasColumnType("varchar(3)");

                entity.Property(e => e.SubSection).HasColumnType("varchar(50)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.ArptreadOnlyErrors)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__ARPTReadO__ARPTI__72831996");
            });

            modelBuilder.Entity<Assignments>(entity =>
            {
                entity.HasKey(e => new { e.CaseUserId, e.SectionId })
                    .HasName("PK__Assignments__4D12691C");

                entity.ToTable("Assignments", "Faculty");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.DaysTaught).HasColumnType("varchar(50)");

                entity.Property(e => e.Notes).HasColumnType("varchar(max)");

                entity.Property(e => e.TeachingPts).HasColumnType("decimal");

                entity.Property(e => e.TeachingRole).HasColumnType("varchar(100)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.CaseUserId)
                    .HasConstraintName("FK__Assignmen__CaseU__4E068D55");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Assignments_CourseSection");

                entity.HasOne(d => d.TeachingRoleNavigation)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.TeachingRole)
                    .HasConstraintName("FK__Assignmen__Teach__4FEED5C7");
            });

            modelBuilder.Entity<Authors>(entity =>
            {
                entity.HasKey(e => e.AuthorId)
                    .HasName("PK__Authors__6E48745E");

                entity.ToTable("Authors", "Publications");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.FacultyId)
                    .HasColumnName("FacultyID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.MName)
                    .HasColumnName("mName")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.PublicationId)
                    .HasName("PK__Book__7AAE4B43");

                entity.ToTable("Book", "Publications");

                entity.Property(e => e.PublicationId)
                    .HasColumnName("PublicationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Chapter).HasColumnType("varchar(10)");

                entity.Property(e => e.City).HasColumnType("varchar(50)");

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Publisher).HasColumnType("varchar(50)");

                entity.Property(e => e.State).HasColumnType("varchar(50)");

                entity.HasOne(d => d.Publication)
                    .WithOne(p => p.Book)
                    .HasForeignKey<Book>(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Book__Publicatio__7BA26F7C");
            });

            modelBuilder.Entity<CandidacyCommittees>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__CandidacyCommitt__397FA664");

                entity.ToTable("CandidacyCommittees", "ARPT");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("fName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IsChair).HasColumnName("isChair");

                entity.Property(e => e.IsMember).HasColumnName("isMember");

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasColumnName("lName")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.CandidacyCommittees)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__Candidacy__ARPTI__20BEE592");
            });

            modelBuilder.Entity<Committees>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__Committees__3D7B1FD1");

                entity.ToTable("Committees", "Faculty");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Accomplishments).HasColumnType("ntext");

                entity.Property(e => e.Audience).HasMaxLength(15);

                entity.Property(e => e.CaseUserId)
                    .IsRequired()
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Committee)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CommitteeType)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.Elected).HasMaxLength(20);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.OtherExplain).HasMaxLength(200);

                entity.Property(e => e.PaidStatus).HasMaxLength(15);

                entity.Property(e => e.Position).HasMaxLength(200);

                entity.Property(e => e.Responsibilities).HasColumnType("ntext");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.State).HasMaxLength(100);

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Committees)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Committee__CaseU__3E6F440A");

                entity.HasOne(d => d.CommitteeTypeNavigation)
                    .WithMany(p => p.Committees)
                    .HasForeignKey(d => d.CommitteeType)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Committee__Commi__3F636843");
            });

            modelBuilder.Entity<CommitteesLookup>(entity =>
            {
                entity.HasKey(e => e.CommitteeType)
                    .HasName("PK_COMMITTEES_LOOKUP");

                entity.ToTable("COMMITTEES_LOOKUP", "Faculty");

                entity.Property(e => e.CommitteeType).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course", "Faculty");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.Chhigh)
                    .HasColumnName("CHHigh")
                    .HasColumnType("decimal");

                entity.Property(e => e.Chlow)
                    .HasColumnName("CHLow")
                    .HasColumnType("decimal");

                entity.Property(e => e.ClinicalHrs).HasColumnType("decimal");

                entity.Property(e => e.CoorHrs).HasColumnType("decimal");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LabHrs).HasColumnType("decimal");

                entity.Property(e => e.LectureHrs).HasColumnType("decimal");

                entity.Property(e => e.Number).HasColumnType("varchar(10)");

                entity.Property(e => e.PracHrs).HasColumnType("decimal");

                entity.Property(e => e.Prefix).HasColumnType("varchar(10)");

                entity.Property(e => e.Program).HasColumnType("varchar(100)");

                entity.Property(e => e.ResearchHrs).HasColumnType("decimal");

                entity.Property(e => e.SemHrs).HasColumnType("decimal");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Syllabus).HasColumnType("varchar(max)");

                entity.Property(e => e.TermCode).HasColumnType("varchar(8)");

                entity.Property(e => e.Title).HasColumnType("varchar(max)");

                entity.HasOne(d => d.TermCodeNavigation)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.TermCode)
                    .HasConstraintName("FK_Course_CourseTerms");
            });

            modelBuilder.Entity<CourseSection>(entity =>
            {
                entity.HasKey(e => e.SectionId)
                    .HasName("PK__CourseSection__38174C36");

                entity.ToTable("CourseSection", "Faculty");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseType).HasColumnType("varchar(4)");

                entity.Property(e => e.Crn).HasColumnName("CRN");

                entity.Property(e => e.DaysTaught).HasColumnType("varchar(50)");

                entity.Property(e => e.DeliveryMethod).HasColumnType("varchar(50)");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasColumnType("varchar(max)");

                entity.Property(e => e.SectionNumber).HasColumnType("varchar(5)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseSection)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_CourseSection_Course");
            });

            modelBuilder.Entity<CourseTerms>(entity =>
            {
                entity.HasKey(e => e.TermCode)
                    .HasName("PK__CourseTerms__2F820635");

                entity.ToTable("CourseTerms", "Faculty");

                entity.Property(e => e.TermCode).HasColumnType("varchar(8)");

                entity.Property(e => e.Term)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CourseXlist>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.CourseIdxlist })
                    .HasName("PK__CourseXList__3446BB52");

                entity.ToTable("CourseXList", "Faculty");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseIdxlist).HasColumnName("CourseIDXlist");
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__Courses__7F5304CF");

                entity.ToTable("Courses", "Obsolete");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.CourseDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.CourseSubject)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Crn)
                    .IsRequired()
                    .HasColumnName("CRN")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.IsIntensive).HasColumnName("isIntensive");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.Term).HasColumnType("varchar(10)");

                entity.Property(e => e.Title).HasColumnType("varchar(200)");

                entity.HasOne(d => d.TermNavigation)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.Term)
                    .HasConstraintName("FK__Courses__Term__00472908");
            });

            modelBuilder.Entity<Credentialslookup>(entity =>
            {
                entity.HasKey(e => e.Acronym)
                    .HasName("PK__CREDENTIALSLOOKU__4FA3F1AD");

                entity.ToTable("CREDENTIALSLOOKUP", "Person");

                entity.Property(e => e.Acronym).HasColumnType("varchar(10)");

                entity.Property(e => e.Description).HasColumnType("varchar(80)");
            });

            modelBuilder.Entity<Degree>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__Degree__49EB1857");

                entity.ToTable("Degree", "Person");

                entity.Property(e => e.Did).HasColumnName("DID");

                entity.Property(e => e.CaseUserId)
                    .IsRequired()
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.City).HasColumnType("varchar(50)");

                entity.Property(e => e.Country).HasColumnType("varchar(50)");

                entity.Property(e => e.Degree1)
                    .IsRequired()
                    .HasColumnName("Degree")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DissertationTitle).HasMaxLength(2000);

                entity.Property(e => e.Distinction).HasMaxLength(100);

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.IsHighest).HasColumnName("isHighest");

                entity.Property(e => e.Major).HasColumnType("varchar(200)");

                entity.Property(e => e.OtherExplain).HasColumnType("varchar(200)");

                entity.Property(e => e.State).HasColumnType("varchar(50)");

                entity.Property(e => e.University)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Degree)
                    .HasForeignKey(d => d.CaseUserId)
                    .HasConstraintName("FK_Degree_Person");
            });

            modelBuilder.Entity<DoctoralCommittees>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__DoctoralCommitte__0CD7E876");

                entity.ToTable("DoctoralCommittees", "Faculty");

                entity.Property(e => e.Did).HasColumnName("DID");

                entity.Property(e => e.CaseUserId)
                    .IsRequired()
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.CommitteeLocale).HasColumnType("varchar(20)");

                entity.Property(e => e.CommitteeName).HasColumnType("varchar(20)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.DmstudentId)
                    .HasColumnName("DMStudentID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("FName")
                    .HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("LName")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherExplain).HasMaxLength(500);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.DoctoralCommittees)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__DoctoralC__CaseU__0DCC0CAF");

                entity.HasOne(d => d.CommitteeLocaleNavigation)
                    .WithMany(p => p.DoctoralCommittees)
                    .HasForeignKey(d => d.CommitteeLocale)
                    .HasConstraintName("FK__DoctoralC__Commi__0FB45521");

                entity.HasOne(d => d.CommitteeNameNavigation)
                    .WithMany(p => p.DoctoralCommittees)
                    .HasForeignKey(d => d.CommitteeName)
                    .HasConstraintName("FK__DoctoralC__Commi__0EC030E8");
            });

            modelBuilder.Entity<DoctoralCommittees1>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__DoctoralCommitte__34BAF147");

                entity.ToTable("DoctoralCommittees", "Obsolete");

                entity.Property(e => e.Did).HasColumnName("DID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.CommitteeLocale).HasColumnType("varchar(20)");

                entity.Property(e => e.CommitteeName).HasColumnType("varchar(20)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("fName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasColumnName("lName")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.DoctoralCommittees1)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__DoctoralC__ARPTI__35AF1580");
            });

            modelBuilder.Entity<Doctoralcommitteeslocalelookup>(entity =>
            {
                entity.HasKey(e => e.CommitteeLocale)
                    .HasName("PK__DOCTORALCOMMITTE__266CD1F0");

                entity.ToTable("DOCTORALCOMMITTEESLOCALELOOKUP", "Faculty");

                entity.Property(e => e.CommitteeLocale).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Doctoralcommitteeslookup>(entity =>
            {
                entity.HasKey(e => e.CommitteeName)
                    .HasName("PK__DOCTORALCOMMITTE__2484897E");

                entity.ToTable("DOCTORALCOMMITTEESLOOKUP", "Faculty");

                entity.Property(e => e.CommitteeName).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<EmergencyContact>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__EmergencyContact__4155D256");

                entity.ToTable("EmergencyContact", "Person");

                entity.Property(e => e.Eid).HasColumnName("EID");

                entity.Property(e => e.AdditionalInfo).HasMaxLength(1000);

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.CellPhone)
                    .HasColumnName("cellPhone")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.HomePhone)
                    .HasColumnName("homePhone")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.OtherContact)
                    .HasColumnName("otherContact")
                    .HasColumnType("varchar(4000)");

                entity.Property(e => e.Pager)
                    .HasColumnName("pager")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Relationship)
                    .HasColumnName("relationship")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkExt)
                    .HasColumnName("workExt")
                    .HasColumnType("varchar(7)");

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("workPhone")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.EmergencyContact)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Emergency__CaseU__4249F68F");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog", "Error");

                entity.Property(e => e.ErrorLogId).HasColumnName("ErrorLogID");

                entity.Property(e => e.ErrorLine).HasColumnType("varchar(max)");

                entity.Property(e => e.ErrorMessage).HasColumnType("varchar(max)");

                entity.Property(e => e.ErrorProcedure).HasColumnType("varchar(max)");

                entity.Property(e => e.ErrorStackTrace).HasColumnType("varchar(max)");

                entity.Property(e => e.ErrorState).HasColumnType("varchar(max)");

                entity.Property(e => e.ErrorTime).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasColumnType("varchar(7)");
            });

            modelBuilder.Entity<Ethnicity>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__Ethnicity__4CC78502");

                entity.ToTable("Ethnicity", "Person");

                entity.Property(e => e.Eid).HasColumnName("EID");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.IsAfricanAmerican).HasColumnName("isAfricanAmerican");

                entity.Property(e => e.IsAsian).HasColumnName("isAsian");

                entity.Property(e => e.IsCaucasian).HasColumnName("isCaucasian");

                entity.Property(e => e.IsHispanic).HasColumnName("isHispanic");

                entity.Property(e => e.IsNativeAmerican).HasColumnName("isNativeAmerican");

                entity.Property(e => e.IsOther).HasColumnName("isOther");

                entity.Property(e => e.IsPacIslander).HasColumnName("isPacIslander");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Ethnicity)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Ethnicity__CaseU__4DBBA93B");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasKey(e => e.CaseUserId)
                    .HasName("PK__Faculty__33FBD738");

                entity.ToTable("Faculty", "Faculty");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.AppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.EraUserName).HasColumnType("varchar(20)");

                entity.Property(e => e.TenureConsideredDate).HasColumnType("varchar(9)");

                entity.Property(e => e.TenureDate).HasColumnType("datetime");

                entity.Property(e => e.TenureStatus).HasColumnType("varchar(20)");

                entity.HasOne(d => d.CaseUser)
                    .WithOne(p => p.Faculty)
                    .HasForeignKey<Faculty>(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Faculty__CaseUse__34EFFB71");

                entity.HasOne(d => d.TenureStatusNavigation)
                    .WithMany(p => p.Faculty)
                    .HasForeignKey(d => d.TenureStatus)
                    .HasConstraintName("FK__Faculty__TenureS__35E41FAA");
            });

            modelBuilder.Entity<FacultyCourse>(entity =>
            {
                entity.HasKey(e => new { e.CaseUserId, e.Cid })
                    .HasName("PK__FacultyCourse__022F717A");

                entity.ToTable("FacultyCourse", "Obsolete");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.FacultyCourse)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__FacultyCo__CaseU__0417B9EC");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.FacultyCourse)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__FacultyCour__CID__032395B3");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.FacultyCourse)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FacultyCourse_ROLELOOKUP");
            });

            modelBuilder.Entity<FacultyMeetingAttendance>(entity =>
            {
                entity.HasKey(e => e.Faid)
                    .HasName("PK__FacultyMeetingAt__43FD34D7");

                entity.ToTable("FacultyMeetingAttendance", "Obsolete");

                entity.Property(e => e.Faid).HasColumnName("FAID");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.FacultyMeetingAttendance)
                    .HasForeignKey(d => d.Sid)
                    .HasConstraintName("FK__FacultyMeet__SID__534A655F");
            });

            modelBuilder.Entity<FacultyMeetingAttendance1>(entity =>
            {
                entity.HasKey(e => e.Faid)
                    .HasName("PK_FacultyMeetingAttendance");

                entity.ToTable("FacultyMeetingAttendance", "ARPT");

                entity.Property(e => e.Faid).HasColumnName("FAID");

                entity.Property(e => e.Attendance)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ExcusedReason).HasColumnType("varchar(500)");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.FacultyMeetingAttendance1)
                    .HasForeignKey(d => d.Sid)
                    .HasConstraintName("FK_FacultyMeetingAttendance_Services");
            });

            modelBuilder.Entity<FacultySchTeach>(entity =>
            {
                entity.HasKey(e => new { e.CaseUserId, e.Dmid })
                    .HasName("PK__FacultySchTeach__2A684B5D");

                entity.ToTable("FacultySchTeach", "Obsolete");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.HoursPerWeek).HasColumnType("decimal");

                entity.Property(e => e.Role).HasColumnType("varchar(50)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.FacultySchTeach)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__FacultySc__CaseU__2B5C6F96");

                entity.HasOne(d => d.Dm)
                    .WithMany(p => p.FacultySchTeach)
                    .HasForeignKey(d => d.Dmid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__FacultySch__DMID__2C5093CF");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.FacultySchTeach)
                    .HasForeignKey(d => d.Role)
                    .HasConstraintName("FK__FacultySch__Role__2D44B808");
            });

            modelBuilder.Entity<FileRepository>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_FileRepository");

                entity.ToTable("FileRepository", "Faculty");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.CaseUserId)
                    .IsRequired()
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.FileBin).IsRequired();

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Location).HasColumnType("varchar(max)");

                entity.Property(e => e.Mimetype)
                    .IsRequired()
                    .HasColumnName("MIMEType")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.FileRepository)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK_FileRepository_ARPT");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.FileRepository)
                    .HasForeignKey(d => d.CaseUserId)
                    .HasConstraintName("FK_FileRepository_Faculty");
            });

            modelBuilder.Entity<Goals>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("PK__Goals__7F1DFAA5");

                entity.ToTable("Goals", "ARPT");

                entity.Property(e => e.Gid).HasColumnName("GID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.Comittee).HasColumnType("varchar(max)");

                entity.Property(e => e.Community).HasColumnType("varchar(max)");

                entity.Property(e => e.IsCurrent).HasColumnName("isCurrent");

                entity.Property(e => e.Mentor).HasColumnType("varchar(max)");

                entity.Property(e => e.Personal).HasColumnType("varchar(max)");

                entity.Property(e => e.Research).HasColumnType("varchar(max)");

                entity.Property(e => e.Scholarship).HasColumnType("varchar(max)");

                entity.Property(e => e.Teaching).HasColumnType("varchar(max)");

                entity.Property(e => e.Training).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.Goals)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__Goals__ARPTID__00121EDE");
            });

            modelBuilder.Entity<Goals1>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("PK__Goals__6C010490");

                entity.ToTable("Goals", "Faculty");

                entity.Property(e => e.Gid).HasColumnName("GID");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.GoalType).HasColumnType("varchar(100)");

                entity.Property(e => e.Goals).HasColumnType("varchar(max)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Goals1)
                    .HasForeignKey(d => d.CaseUserId)
                    .HasConstraintName("FK__Goals__CaseUserI__6CF528C9");
            });

            modelBuilder.Entity<GroupOffice>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.OfficeNum })
                    .HasName("PK__GroupOffice__592D5BE7");

                entity.ToTable("GroupOffice", "Person");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.OfficeNum).HasColumnType("varchar(10)");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupOffice)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__GroupOffi__Group__67515E0C");

                entity.HasOne(d => d.OfficeNumNavigation)
                    .WithMany(p => p.GroupOffice)
                    .HasForeignKey(d => d.OfficeNum)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__GroupOffi__Offic__68458245");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK__Groups__555CCB03");

                entity.ToTable("Groups", "Person");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.IsDm).HasColumnName("isDM");

                entity.Property(e => e.IsGrant).HasColumnName("isGrant");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Phone).HasColumnType("varchar(14)");
            });

            modelBuilder.Entity<GuestLectures>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("PK__GuestLectures__2E0DF3B8");

                entity.ToTable("GuestLectures", "ARPT");

                entity.Property(e => e.Gid).HasColumnName("GID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.Course)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasColumnType("varchar(500)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.GuestLectures)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__GuestLect__ARPTI__2F0217F1");
            });

            modelBuilder.Entity<Honors>(entity =>
            {
                entity.HasKey(e => e.Hid)
                    .HasName("PK__Honors__777CD8DD");

                entity.ToTable("Honors", "Faculty");

                entity.Property(e => e.Hid).HasColumnName("HID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.Award)
                    .IsRequired()
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.AwardDate).HasColumnType("datetime");

                entity.Property(e => e.AwardStatus).HasColumnType("varchar(10)");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.GrantingOrg)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.IsAwarded).HasColumnName("isAwarded");

                entity.Property(e => e.IsResearchPubMat).HasColumnName("isResearchPubMat");

                entity.Property(e => e.Location).HasColumnType("varchar(150)");

                entity.Property(e => e.NominationDate).HasColumnType("datetime");

                entity.Property(e => e.OldAwardDate).HasColumnType("varchar(20)");

                entity.Property(e => e.OldNominationDate).HasColumnType("varchar(20)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.Honors)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__Honors__ARPTID__7870FD16");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Honors)
                    .HasForeignKey(d => d.CaseUserId)
                    .HasConstraintName("FK__Honors__CaseUser__7965214F");
            });

            modelBuilder.Entity<IndependentStudies>(entity =>
            {
                entity.HasKey(e => e.Isid)
                    .HasName("PK__IndependentStudi__28551A62");

                entity.ToTable("IndependentStudies", "ARPT");

                entity.Property(e => e.Isid).HasColumnName("ISID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("fName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasColumnName("lName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.IndependentStudies)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__Independe__ARPTI__29493E9B");
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.HasKey(e => e.PublicationId)
                    .HasName("PK__Journal__7D8AB7EE");

                entity.ToTable("Journal", "Publications");

                entity.Property(e => e.PublicationId)
                    .HasColumnName("PublicationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.JournalTitle)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PageNumber).HasColumnType("varchar(10)");

                entity.Property(e => e.Section).HasColumnType("varchar(10)");

                entity.Property(e => e.Volume).HasColumnType("varchar(10)");

                entity.HasOne(d => d.Publication)
                    .WithOne(p => p.Journal)
                    .HasForeignKey<Journal>(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Journal__Publica__7E7EDC27");
            });

            modelBuilder.Entity<MeetingAttendence>(entity =>
            {
                entity.HasKey(e => e.Aids)
                    .HasName("PK__MeetingAtteneden__4AA010C5");

                entity.ToTable("MeetingAttendence", "Faculty");

                entity.Property(e => e.Aids).HasColumnName("AIDS");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FacultyNameId)
                    .HasColumnName("FacultyNameID")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.MeetingId).HasColumnName("MeetingID");

                entity.Property(e => e.Mname)
                    .HasColumnName("MName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Role).HasColumnType("varchar(100)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.MeetingAttendence)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MeetingAttendence_Faculty");

                entity.HasOne(d => d.Meeting)
                    .WithMany(p => p.MeetingAttendence)
                    .HasForeignKey(d => d.MeetingId)
                    .HasConstraintName("FK__MeetingAt__Meeti__4B9434FE");
            });

            modelBuilder.Entity<MeetingNotes>(entity =>
            {
                entity.HasKey(e => e.Mnid)
                    .HasName("PK__MeetingNotes__42FEEEFD");

                entity.ToTable("MeetingNotes", "Faculty");

                entity.Property(e => e.Mnid).HasColumnName("MNID");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MeetingId).HasColumnName("MeetingID");

                entity.Property(e => e.NotesLocation).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Meeting)
                    .WithMany(p => p.MeetingNotes)
                    .HasForeignKey(d => d.MeetingId)
                    .HasConstraintName("FK__MeetingNo__Meeti__43F31336");
            });

            modelBuilder.Entity<Meetings>(entity =>
            {
                entity.HasKey(e => e.MeetingId)
                    .HasName("PK__Meetings__3D4615A7");

                entity.ToTable("Meetings", "Faculty");

                entity.Property(e => e.MeetingId).HasColumnName("MeetingID");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Location).HasColumnType("varchar(500)");

                entity.Property(e => e.MeetingEndDate).HasColumnType("datetime");

                entity.Property(e => e.MeetingStartDate).HasColumnType("datetime");

                entity.Property(e => e.MeetingSubject).HasColumnType("varchar(max)");

                entity.Property(e => e.MeetingType).HasColumnType("varchar(500)");

                entity.Property(e => e.OtherExplain).HasColumnType("varchar(500)");
            });

            modelBuilder.Entity<Mentors>(entity =>
            {
                entity.HasKey(e => e.Mid)
                    .HasName("PK__Mentors__181EB299");

                entity.ToTable("Mentors", "Faculty");

                entity.Property(e => e.Mid).HasColumnName("MID");

                entity.Property(e => e.Activity).HasColumnType("varchar(max)");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.Comment).HasColumnType("varchar(max)");

                entity.Property(e => e.CommunicationFreq).HasColumnType("varchar(150)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("FName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("LName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MentorId)
                    .HasColumnName("MentorID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.MentorType).HasColumnType("varchar(10)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.Mentors)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK_Mentors_ARPT");

                entity.HasOne(d => d.Mentor)
                    .WithMany(p => p.Mentors)
                    .HasForeignKey(d => d.MentorId)
                    .HasConstraintName("FK__Mentors__MentorI__1912D6D2");
            });

            modelBuilder.Entity<NewCourseDevelopment>(entity =>
            {
                entity.HasKey(e => e.Ncdid)
                    .HasName("PK__NewCourseDevelop__2B31870D");

                entity.ToTable("NewCourseDevelopment", "ARPT");

                entity.Property(e => e.Ncdid).HasColumnName("NCDID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.NewCourseDevelopment)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__NewCourse__ARPTI__7CEB9970");
            });

            modelBuilder.Entity<Nominators>(entity =>
            {
                entity.HasKey(e => e.Nid)
                    .HasName("PK__Nominators__7B4D69C1");

                entity.ToTable("Nominators", "Faculty");

                entity.Property(e => e.Nid).HasColumnName("NID");

                entity.Property(e => e.Affiliation).HasColumnType("varchar(50)");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Hid).HasColumnName("HID");

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.H)
                    .WithMany(p => p.Nominators)
                    .HasForeignKey(d => d.Hid)
                    .HasConstraintName("FK__Nominators__HID__7C418DFA");
            });

            modelBuilder.Entity<NonCreditInstruction>(entity =>
            {
                entity.HasKey(e => e.Ncid)
                    .HasName("PK__NonCreditInstruc__18499B22");

                entity.ToTable("NonCreditInstruction", "Faculty");

                entity.Property(e => e.Ncid).HasColumnName("NCID");

                entity.Property(e => e.AcadOrProf).HasMaxLength(30);

                entity.Property(e => e.Audience).HasMaxLength(100);

                entity.Property(e => e.CaseUserId)
                    .IsRequired()
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Course).HasMaxLength(500);

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InstructionType).HasMaxLength(50);

                entity.Property(e => e.OtherExplain).HasMaxLength(500);

                entity.Property(e => e.SponseringOrganization).HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Topic).HasMaxLength(500);

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.NonCreditInstruction)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__NonCredit__CaseU__193DBF5B");

                entity.HasOne(d => d.InstructionTypeNavigation)
                    .WithMany(p => p.NonCreditInstruction)
                    .HasForeignKey(d => d.InstructionType)
                    .HasConstraintName("FK__NonCredit__Instr__1A31E394");
            });

            modelBuilder.Entity<NonTenureFoci>(entity =>
            {
                entity.HasKey(e => e.CaseUserId)
                    .HasName("PK_NonTenureFoci");

                entity.ToTable("NonTenureFoci", "Faculty");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.HasOne(d => d.CaseUser)
                    .WithOne(p => p.NonTenureFoci)
                    .HasForeignKey<NonTenureFoci>(d => d.CaseUserId)
                    .HasConstraintName("FK__NonTenure__CaseU__154245EE");
            });

            modelBuilder.Entity<Noncreditinstructionlookup>(entity =>
            {
                entity.HasKey(e => e.InstructionType)
                    .HasName("PK__NONCREDITINSTRUC__166152B0");

                entity.ToTable("NONCREDITINSTRUCTIONLOOKUP", "Faculty");

                entity.Property(e => e.InstructionType).HasMaxLength(50);
            });

            modelBuilder.Entity<ObsoleteAuthors>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PK__Authors__646A0469");

                entity.ToTable("ObsoleteAuthors", "Obsolete");

                entity.Property(e => e.Aid).HasColumnName("AID");

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LName)
                    .HasColumnName("lName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MName)
                    .HasColumnName("mName")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ObsoleteBook>(entity =>
            {
                entity.HasKey(e => e.Puid)
                    .HasName("PK__Book__71C3FF87");

                entity.ToTable("ObsoleteBook", "Obsolete");

                entity.Property(e => e.Puid)
                    .HasColumnName("PUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Chapter).HasColumnType("varchar(10)");

                entity.Property(e => e.City).HasColumnType("varchar(50)");

                entity.Property(e => e.Publisher).HasColumnType("varchar(50)");

                entity.Property(e => e.State).HasColumnType("varchar(50)");

                entity.HasOne(d => d.Pu)
                    .WithOne(p => p.ObsoleteBook)
                    .HasForeignKey<ObsoleteBook>(d => d.Puid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ObsoleteBo__PUID__543E8998");
            });

            modelBuilder.Entity<ObsoleteJournal>(entity =>
            {
                entity.HasKey(e => e.Puid)
                    .HasName("PK__Journal__74A06C32");

                entity.ToTable("ObsoleteJournal", "Obsolete");

                entity.Property(e => e.Puid)
                    .HasColumnName("PUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.JournalTitle)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PageNumber).HasColumnType("varchar(10)");

                entity.Property(e => e.Section).HasColumnType("varchar(10)");

                entity.Property(e => e.Volume).HasColumnType("varchar(10)");

                entity.HasOne(d => d.Pu)
                    .WithOne(p => p.ObsoleteJournal)
                    .HasForeignKey<ObsoleteJournal>(d => d.Puid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ObsoleteJo__PUID__5532ADD1");
            });

            modelBuilder.Entity<ObsoletePresentations>(entity =>
            {
                entity.HasKey(e => e.Prid)
                    .HasName("PK__Presentations__60997385");

                entity.ToTable("ObsoletePresentations", "Obsolete");

                entity.Property(e => e.Prid).HasColumnName("PRID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.City).HasColumnType("varchar(40)");

                entity.Property(e => e.Conference).HasColumnType("varchar(100)");

                entity.Property(e => e.Country).HasColumnType("varchar(50)");

                entity.Property(e => e.FullCitation).HasColumnType("varchar(max)");

                entity.Property(e => e.IsInvited).HasColumnName("isInvited");

                entity.Property(e => e.IsRefereed).HasColumnName("isRefereed");

                entity.Property(e => e.PresentationDate).HasColumnType("varchar(20)");

                entity.Property(e => e.PresentationType).HasColumnType("varchar(20)");

                entity.Property(e => e.State).HasColumnType("varchar(2)");

                entity.Property(e => e.Title).HasColumnType("varchar(100)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.ObsoletePresentations)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__Presentat__ARPTI__618D97BE");

                entity.HasOne(d => d.PresentationTypeNavigation)
                    .WithMany(p => p.ObsoletePresentations)
                    .HasForeignKey(d => d.PresentationType)
                    .HasConstraintName("FK__Presentat__Prese__6281BBF7");
            });

            modelBuilder.Entity<ObsoletePresentationsAuthors>(entity =>
            {
                entity.HasKey(e => new { e.Prid, e.Aid })
                    .HasName("PK__PresentationsAut__6B1701F8");

                entity.ToTable("ObsoletePresentationsAuthors", "Obsolete");

                entity.Property(e => e.Prid).HasColumnName("PRID");

                entity.Property(e => e.Aid).HasColumnName("AID");

                entity.HasOne(d => d.A)
                    .WithMany(p => p.ObsoletePresentationsAuthors)
                    .HasForeignKey(d => d.Aid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Presentatio__AID__6CFF4A6A");

                entity.HasOne(d => d.Pr)
                    .WithMany(p => p.ObsoletePresentationsAuthors)
                    .HasForeignKey(d => d.Prid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Presentati__PRID__6C0B2631");
            });

            modelBuilder.Entity<ObsoletePublications>(entity =>
            {
                entity.HasKey(e => e.Puid)
                    .HasName("PK__Publications__5BD4BE68");

                entity.ToTable("ObsoletePublications", "Obsolete");

                entity.Property(e => e.Puid).HasColumnName("PUID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.FullCitation).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDatabased).HasColumnName("isDatabased");

                entity.Property(e => e.IsPeerReviewed).HasColumnName("isPeerReviewed");

                entity.Property(e => e.IsStudentCoAuthored).HasColumnName("isStudentCoAuthored");

                entity.Property(e => e.PublicationStatus).HasColumnType("varchar(50)");

                entity.Property(e => e.PublicationType).HasColumnType("varchar(30)");

                entity.Property(e => e.Title).HasColumnType("varchar(100)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.ObsoletePublications)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__Publicati__ARPTI__5CC8E2A1");

                entity.HasOne(d => d.PublicationStatusNavigation)
                    .WithMany(p => p.ObsoletePublications)
                    .HasForeignKey(d => d.PublicationStatus)
                    .HasConstraintName("FK__Publicati__Publi__5DBD06DA");

                entity.HasOne(d => d.PublicationTypeNavigation)
                    .WithMany(p => p.ObsoletePublications)
                    .HasForeignKey(d => d.PublicationType)
                    .HasConstraintName("FK__Publicati__Publi__5EB12B13");
            });

            modelBuilder.Entity<ObsoletePublicationsAuthors>(entity =>
            {
                entity.HasKey(e => new { e.Puid, e.Aid })
                    .HasName("PK__PublicationsAuth__67467114");

                entity.ToTable("ObsoletePublicationsAuthors", "Obsolete");

                entity.Property(e => e.Puid).HasColumnName("PUID");

                entity.Property(e => e.Aid).HasColumnName("AID");

                entity.HasOne(d => d.A)
                    .WithMany(p => p.ObsoletePublicationsAuthors)
                    .HasForeignKey(d => d.Aid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Publication__AID__692EB986");

                entity.HasOne(d => d.Pu)
                    .WithMany(p => p.ObsoletePublicationsAuthors)
                    .HasForeignKey(d => d.Puid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Publicatio__PUID__683A954D");
            });

            modelBuilder.Entity<ObsoleteWeb>(entity =>
            {
                entity.HasKey(e => e.Puid)
                    .HasName("PK__Web__6EE792DC");

                entity.ToTable("ObsoleteWeb", "Obsolete");

                entity.Property(e => e.Puid)
                    .HasColumnName("PUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.WebPageTitle).HasColumnType("varchar(50)");

                entity.Property(e => e.WebSiteTitle)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Pu)
                    .WithOne(p => p.ObsoleteWeb)
                    .HasForeignKey<ObsoleteWeb>(d => d.Puid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Web__PUID__6FDBB715");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.HasKey(e => e.OfficeNum)
                    .HasName("PK__Office__57451375");

                entity.ToTable("Office", "Person");

                entity.Property(e => e.OfficeNum).HasColumnType("varchar(10)");

                entity.Property(e => e.Location).HasMaxLength(50);
            });

            modelBuilder.Entity<OtherResearch>(entity =>
            {
                entity.HasKey(e => e.Nrfid)
                    .HasName("PK__NonFundedResearc__3C5C130F");

                entity.ToTable("OtherResearch", "ARPT");

                entity.Property(e => e.Nrfid).HasColumnName("NRFID");

                entity.Property(e => e.Additional).HasColumnType("varchar(max)");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.NonFunded).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.OtherResearch)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__NonFunded__ARPTI__3D503748");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.CaseUserId)
                    .HasName("PK__Person__2C5AB570");

                entity.ToTable("Person", "Person");

                entity.HasIndex(e => e.PersonId)
                    .HasName("UQ__Person__6C2B21C2")
                    .IsUnique();

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.CellPhone).HasColumnType("varchar(14)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmplId)
                    .HasColumnName("EmplID")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("fName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FacultyId)
                    .HasColumnName("FacultyID")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasColumnName("lName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MName)
                    .HasColumnName("mName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OtherEmail).HasColumnType("varchar(50)");

                entity.Property(e => e.Pager).HasColumnType("varchar(25)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PersonID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PersonStatus).HasColumnType("varchar(20)");

                entity.Property(e => e.PersonType).HasColumnType("varchar(20)");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.PictureLink).HasColumnType("varchar(255)");

                entity.Property(e => e.PreferredName)
                    .HasColumnName("preferredName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Prefix).HasColumnType("varchar(15)");

                entity.Property(e => e.ProfileLink).HasColumnType("varchar(255)");

                entity.Property(e => e.ResignationDate).HasColumnType("datetime");

                entity.Property(e => e.Suffix).HasMaxLength(50);
            });

            modelBuilder.Entity<PersonCredentials>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__PersonCredential__518C3A1F");

                entity.ToTable("PersonCredentials", "Person");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.AcquireDate).HasColumnType("datetime");

                entity.Property(e => e.Acronym)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CaseUserId)
                    .IsRequired()
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.CredentialExpDate).HasColumnType("datetime");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.LicenseNumber).HasColumnType("varchar(100)");

                entity.HasOne(d => d.AcronymNavigation)
                    .WithMany(p => p.PersonCredentials)
                    .HasForeignKey(d => d.Acronym)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__PersonCre__Acron__187EA54C");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.PersonCredentials)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__PersonCre__CaseU__52805E58");
            });

            modelBuilder.Entity<PersonGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.CaseUserId })
                    .HasName("PK__PersonGroup__5CFDECCB");

                entity.ToTable("PersonGroup", "Person");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.PersonGroup)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__PersonGro__CaseU__5DF21104");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.PersonGroup)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__PersonGro__Group__6DFE5B9B");
            });

            modelBuilder.Entity<PersonOffice>(entity =>
            {
                entity.HasKey(e => new { e.OfficeNum, e.CaseUserId })
                    .HasName("PK__PersonOffice__60CE7DAF");

                entity.ToTable("PersonOffice", "Person");

                entity.HasIndex(e => new { e.CaseUserId, e.OfficeNum })
                    .HasName("IDX_PERSONOFFICE")
                    .IsUnique();

                entity.Property(e => e.OfficeNum).HasColumnType("varchar(10)");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.PersonOffice)
                    .HasForeignKey(d => d.CaseUserId)
                    .HasConstraintName("FK__PersonOff__CaseU__61C2A1E8");

                entity.HasOne(d => d.OfficeNumNavigation)
                    .WithMany(p => p.PersonOffice)
                    .HasForeignKey(d => d.OfficeNum)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__PersonOff__Offic__6FE6A40D");
            });

            modelBuilder.Entity<PersonToPresentations>(entity =>
            {
                entity.HasKey(e => new { e.PresentationId, e.CaseUserId })
                    .HasName("PK__PersonToPresenta__6A77E37A");

                entity.ToTable("PersonToPresentations", "Publications");

                entity.Property(e => e.PresentationId).HasColumnName("PresentationID");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.PersonToPresentations)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__PersonToP__CaseU__201FC714");

                entity.HasOne(d => d.Presentation)
                    .WithMany(p => p.PersonToPresentations)
                    .HasForeignKey(d => d.PresentationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__PersonToP__Prese__73B734F1");
            });

            modelBuilder.Entity<PersonToPublications>(entity =>
            {
                entity.HasKey(e => new { e.PublicationId, e.CaseUserId })
                    .HasName("PK__PersonToPublicat__63CAE5EB");

                entity.ToTable("PersonToPublications", "Publications");

                entity.Property(e => e.PublicationId).HasColumnName("PublicationID");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.PersonToPublications)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__PersonToP__CaseU__22080F86");

                entity.HasOne(d => d.Publication)
                    .WithMany(p => p.PersonToPublications)
                    .HasForeignKey(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__PersonToP__Publi__64BF0A24");
            });

            modelBuilder.Entity<Persontypeslookup>(entity =>
            {
                entity.HasKey(e => e.PersonType)
                    .HasName("PK__PERSONTYPESLOOKU__2A726CFE");

                entity.ToTable("PERSONTYPESLOOKUP", "Person");

                entity.Property(e => e.PersonType).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Presentations>(entity =>
            {
                entity.HasKey(e => e.PresentationId)
                    .HasName("PK__Presentations__679B76CF");

                entity.ToTable("Presentations", "Publications");

                entity.Property(e => e.PresentationId).HasColumnName("PresentationID");

                entity.Property(e => e.Abstract).HasColumnType("varchar(max)");

                entity.Property(e => e.City).HasColumnType("varchar(40)");

                entity.Property(e => e.Conference).HasColumnType("varchar(500)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FileLocation).HasColumnType("varchar(1000)");

                entity.Property(e => e.FullCitation).HasColumnType("varchar(max)");

                entity.Property(e => e.IsAccepted).HasColumnName("isAccepted");

                entity.Property(e => e.IsInvited).HasColumnName("isInvited");

                entity.Property(e => e.IsPublishedElsewhere).HasColumnName("isPublishedElsewhere");

                entity.Property(e => e.IsPublishedProceedings).HasColumnName("isPublishedProceedings");

                entity.Property(e => e.IsRefereed).HasColumnName("isRefereed");

                entity.Property(e => e.Location).HasColumnType("varchar(500)");

                entity.Property(e => e.MeetingType).HasColumnType("varchar(50)");

                entity.Property(e => e.PresentationDate).HasColumnType("datetime");

                entity.Property(e => e.PresentationType).HasColumnType("varchar(20)");

                entity.Property(e => e.Scope).HasColumnType("varchar(50)");

                entity.Property(e => e.SponsoringOrg).HasColumnType("varchar(500)");

                entity.Property(e => e.State).HasColumnType("varchar(2)");

                entity.Property(e => e.Title).HasColumnType("varchar(500)");

                entity.HasOne(d => d.PresentationTypeNavigation)
                    .WithMany(p => p.Presentations)
                    .HasForeignKey(d => d.PresentationType)
                    .HasConstraintName("FK__Presentat__Prese__23F057F8");
            });

            modelBuilder.Entity<PresentationsAuthors>(entity =>
            {
                entity.HasKey(e => new { e.PresentationId, e.AuthorId })
                    .HasName("PK__PresentationsAut__74014DB4");

                entity.ToTable("PresentationsAuthors", "Publications");

                entity.Property(e => e.PresentationId).HasColumnName("PresentationID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.PresentationsAuthors)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Presentat__Autho__4A2B0F79");

                entity.HasOne(d => d.Presentation)
                    .WithMany(p => p.PresentationsAuthors)
                    .HasForeignKey(d => d.PresentationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Presentat__Prese__25D8A06A");
            });

            modelBuilder.Entity<Presentationtypeslookup>(entity =>
            {
                entity.HasKey(e => e.PresentationType)
                    .HasName("PK__PRESENTATIONTYPE__58042D84");

                entity.ToTable("PRESENTATIONTYPESLOOKUP", "Publications");

                entity.Property(e => e.PresentationType).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Programlookup>(entity =>
            {
                entity.HasKey(e => e.ProgramName)
                    .HasName("PK__PROGRAMLOOKUP__229C410C");

                entity.ToTable("PROGRAMLOOKUP", "ARPT");

                entity.Property(e => e.ProgramName).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Publications>(entity =>
            {
                entity.HasKey(e => e.PublicationId)
                    .HasName("PK__Publications__5FFA5507");

                entity.ToTable("Publications", "Publications");

                entity.Property(e => e.PublicationId).HasColumnName("PublicationID");

                entity.Property(e => e.AcceptedDate).HasColumnType("datetime");

                entity.Property(e => e.Audience).HasMaxLength(25);

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Editors).HasMaxLength(200);

                entity.Property(e => e.EpublishedDate)
                    .HasColumnName("EPublishedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileLocation).HasColumnType("varchar(1000)");

                entity.Property(e => e.InPressDate).HasColumnType("datetime");

                entity.Property(e => e.IsDatabased).HasColumnName("isDatabased");

                entity.Property(e => e.IsPeerReviewed).HasColumnName("isPeerReviewed");

                entity.Property(e => e.IsPublic).HasColumnName("isPublic");

                entity.Property(e => e.IsRefereed).HasColumnName("isRefereed");

                entity.Property(e => e.IsStudentCoAuthored).HasColumnName("isStudentCoAuthored");

                entity.Property(e => e.PubMedId)
                    .HasColumnName("PubMedID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PublicationStatus).HasColumnType("varchar(50)");

                entity.Property(e => e.PublicationType).HasColumnType("varchar(250)");

                entity.Property(e => e.PublishedDate).HasColumnType("datetime");

                entity.Property(e => e.SubmissionDate).HasColumnType("datetime");

                entity.HasOne(d => d.PublicationStatusNavigation)
                    .WithMany(p => p.Publications)
                    .HasForeignKey(d => d.PublicationStatus)
                    .HasConstraintName("FK__Publicati__Publi__61E29D79");
            });

            modelBuilder.Entity<PublicationsAuthors>(entity =>
            {
                entity.HasKey(e => new { e.PublicationId, e.AuthorId })
                    .HasName("PK__PublicationsAuth__7030BCD0");

                entity.ToTable("PublicationsAuthors", "Publications");

                entity.Property(e => e.PublicationId).HasColumnName("PublicationID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.PublicationsAuthors)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Publicati__Autho__28B50D15");

                entity.HasOne(d => d.Publication)
                    .WithMany(p => p.PublicationsAuthors)
                    .HasForeignKey(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Publicati__Publi__7124E109");
            });

            modelBuilder.Entity<Publicationstatuslookup>(entity =>
            {
                entity.HasKey(e => e.PublicationStatus)
                    .HasName("PK__PUBLICATIONSTATU__561BE512");

                entity.ToTable("PUBLICATIONSTATUSLOOKUP", "Publications");

                entity.Property(e => e.PublicationStatus).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Publicationtypeslookup>(entity =>
            {
                entity.HasKey(e => e.PublicationType)
                    .HasName("PK__PUBLICATIONTYPES__59EC75F6");

                entity.ToTable("PUBLICATIONTYPESLOOKUP", "Publications");

                entity.Property(e => e.PublicationType).HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<Ranklookup>(entity =>
            {
                entity.HasKey(e => e.RankTitle)
                    .HasName("PK__RANKLOOKUP__0600025E");

                entity.ToTable("RANKLOOKUP", "Faculty");

                entity.Property(e => e.RankTitle).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Ranks>(entity =>
            {
                entity.HasKey(e => e.RankId)
                    .HasName("PK__RanksBackup__6EDD713B");

                entity.ToTable("Ranks", "Faculty");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.CaseUserId)
                    .IsRequired()
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.IsCurrent).HasColumnName("isCurrent");

                entity.Property(e => e.PromotionDate).HasColumnType("datetime");

                entity.Property(e => e.RankTitle)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Ranks)
                    .HasForeignKey(d => d.CaseUserId)
                    .HasConstraintName("FK_RanksBackup_Faculty");

                entity.HasOne(d => d.RankTitleNavigation)
                    .WithMany(p => p.Ranks)
                    .HasForeignKey(d => d.RankTitle)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RanksBackup_RANKLOOKUP");
            });

            modelBuilder.Entity<RanksOld>(entity =>
            {
                entity.HasKey(e => new { e.CaseUserId, e.RankTitle })
                    .HasName("PK__Ranks__07E84AD0");

                entity.ToTable("RanksOld", "Faculty");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.RankTitle).HasColumnType("varchar(50)");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.IsCurrent).HasColumnName("isCurrent");

                entity.Property(e => e.PromotionDate).HasColumnType("datetime");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.RanksOld)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Ranks__CaseUserI__08DC6F09");

                entity.HasOne(d => d.RankTitleNavigation)
                    .WithMany(p => p.RanksOld)
                    .HasForeignKey(d => d.RankTitle)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Ranks__RankTitle__09D09342");
            });

            modelBuilder.Entity<RecruitmentActivities>(entity =>
            {
                entity.HasKey(e => e.Raid)
                    .HasName("PK__RecruitmentActiv__533F7867");

                entity.ToTable("RecruitmentActivities", "Obsolete");

                entity.Property(e => e.Raid).HasColumnName("RAID");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ActivityDate).HasColumnType("varchar(20)");

                entity.Property(e => e.GroupName).HasColumnType("varchar(200)");

                entity.Property(e => e.Location).HasColumnType("varchar(200)");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.RecruitmentActivities)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Recruitment__SID__54339CA0");
            });

            modelBuilder.Entity<Rolelookup>(entity =>
            {
                entity.HasKey(e => e.Role)
                    .HasName("PK_ROLELOOKUP");

                entity.ToTable("ROLELOOKUP", "Faculty");

                entity.Property(e => e.Role).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Roles__7A4F23E7");

                entity.ToTable("Roles", "Faculty");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.CaseUserId)
                    .IsRequired()
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.RoleDescription).HasColumnType("varchar(1500)");

                entity.Property(e => e.RoleTitle).HasColumnType("varchar(300)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Roles__CaseUserI__7B434820");
            });

            modelBuilder.Entity<SchRoleLookup>(entity =>
            {
                entity.HasKey(e => e.Role)
                    .HasName("PK__SCH_ROLE_LOOKUP__1C1A2C06");

                entity.ToTable("SCH_ROLE_LOOKUP", "Obsolete");

                entity.Property(e => e.Role).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<SchTeach>(entity =>
            {
                entity.HasKey(e => e.Dmid)
                    .HasName("PK__SchTeach__278BDEB2");

                entity.ToTable("SchTeach", "Obsolete");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CourseLevel).HasColumnType("varchar(15)");

                entity.Property(e => e.CourseName).HasColumnType("varchar(500)");

                entity.Property(e => e.CoursePrefix)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CreditHours).HasColumnType("decimal");

                entity.Property(e => e.CrossListing).HasMaxLength(200);

                entity.Property(e => e.DeliveryMode).HasColumnType("varchar(100)");

                entity.Property(e => e.Division).HasColumnType("varchar(20)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IndependentStudyTopic).HasColumnType("varchar(max)");

                entity.Property(e => e.IsNewCoursePrep).HasColumnName("isNewCoursePrep");

                entity.Property(e => e.IsNewFormat).HasColumnName("isNewFormat");

                entity.Property(e => e.OtherExplain).HasMaxLength(200);

                entity.Property(e => e.SyllabusLocation).HasColumnType("varchar(100)");

                entity.Property(e => e.Term)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.TermNavigation)
                    .WithMany(p => p.SchTeach)
                    .HasForeignKey(d => d.Term)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__SchTeach__Term__288002EB");
            });

            modelBuilder.Entity<SchTeachStudents>(entity =>
            {
                entity.HasKey(e => e.StudentDmid)
                    .HasName("PK__SchTeachStudents__2F2D007A");

                entity.ToTable("SchTeachStudents", "Obsolete");

                entity.Property(e => e.StudentDmid)
                    .HasColumnName("StudentDMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Dmid)
                    .IsRequired()
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(100);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(200);

                entity.Property(e => e.Mname)
                    .HasColumnName("MName")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Dm)
                    .WithMany(p => p.SchTeachStudents)
                    .HasForeignKey(d => d.Dmid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__SchTeachSt__DMID__302124B3");
            });

            modelBuilder.Entity<SchTermLookup>(entity =>
            {
                entity.HasKey(e => e.Term)
                    .HasName("PK__SCH_TERM_LOOKUP__25A39640");

                entity.ToTable("SCH_TERM_LOOKUP", "Obsolete");

                entity.Property(e => e.Term).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ServiceAttendance>(entity =>
            {
                entity.HasKey(e => e.Said)
                    .HasName("PK__ServiceAttendanc__46D9A182");

                entity.ToTable("ServiceAttendance", "Obsolete");

                entity.Property(e => e.Said).HasColumnName("SAID");

                entity.Property(e => e.AttendedCommencement).HasColumnName("attendedCommencement");

                entity.Property(e => e.AttendedFallConvocation).HasColumnName("attendedFallConvocation");

                entity.Property(e => e.AttendedSpringConvocation).HasColumnName("attendedSpringConvocation");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.ServiceAttendance)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ServiceAtte__SID__47CDC5BB");
            });

            modelBuilder.Entity<ServiceCommittees>(entity =>
            {
                entity.HasKey(e => e.Scid)
                    .HasName("PK__ServiceCommittee__4C927AD8");

                entity.ToTable("ServiceCommittees", "ARPT");

                entity.Property(e => e.Scid).HasColumnName("SCID");

                entity.Property(e => e.Acomplishments).HasColumnType("varchar(max)");

                entity.Property(e => e.Activity).HasColumnType("varchar(max)");

                entity.Property(e => e.CommitteeName).HasColumnType("varchar(200)");

                entity.Property(e => e.CommitteeType).HasColumnType("varchar(20)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsChair).HasColumnName("isChair");

                entity.Property(e => e.IsEditorialBoard).HasColumnName("isEditorialBoard");

                entity.Property(e => e.IsGrantReviewer).HasColumnName("isGrantReviewer");

                entity.Property(e => e.IsLeader).HasColumnName("isLeader");

                entity.Property(e => e.IsMember).HasColumnName("isMember");

                entity.Property(e => e.IsReviewPanel).HasColumnName("isReviewPanel");

                entity.Property(e => e.OtherExplaination).HasColumnType("varchar(max)");

                entity.Property(e => e.Role).HasColumnType("varchar(150)");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.CommitteeTypeNavigation)
                    .WithMany(p => p.ServiceCommittees)
                    .HasForeignKey(d => d.CommitteeType)
                    .HasConstraintName("FK__ServiceCo__Commi__4E7AC34A");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.ServiceCommittees)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ServiceComm__SID__4D869F11");
            });

            modelBuilder.Entity<ServiceWritingWorkshops>(entity =>
            {
                entity.HasKey(e => e.Swwid)
                    .HasName("PK__ServiceWritingWo__49B60E2D");

                entity.ToTable("ServiceWritingWorkshops", "Obsolete");

                entity.Property(e => e.Swwid).HasColumnName("SWWID");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.ServiceWritingWorkshops)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ServiceWrit__SID__4AAA3266");
            });

            modelBuilder.Entity<Servicecommitteetypeslookup>(entity =>
            {
                entity.HasKey(e => e.CommitteeType)
                    .HasName("PK__SERVICECOMMITTEE__4214EC65");

                entity.ToTable("SERVICECOMMITTEETYPESLOOKUP", "ARPT");

                entity.Property(e => e.CommitteeType).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Services__3F387FBA");

                entity.ToTable("Services", "ARPT");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.AdministrativeRoles).HasColumnType("varchar(200)");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.CommunityOther).HasColumnType("varchar(max)");

                entity.Property(e => e.IsCommencement).HasColumnName("isCommencement");

                entity.Property(e => e.IsRetreat).HasColumnName("isRetreat");

                entity.Property(e => e.ProfessionOther).HasColumnType("varchar(max)");

                entity.Property(e => e.SchoolOther).HasColumnType("varchar(max)");

                entity.Property(e => e.UnivOther).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__Services__ARPTID__5E5203B7");
            });

            modelBuilder.Entity<Specialties>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Specialties__7A8E4FB2");

                entity.ToTable("Specialties", "Faculty");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(50);

                entity.Property(e => e.IsContributing).HasColumnName("isContributing");

                entity.Property(e => e.IsReportable).HasColumnName("isReportable");

                entity.Property(e => e.IsResearchArea).HasColumnName("isResearchArea");

                entity.Property(e => e.Specialty)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Specialties)
                    .HasForeignKey(d => d.CaseUserId)
                    .HasConstraintName("FK__Specialti__CaseU__7B8273EB");
            });

            modelBuilder.Entity<Statuslookup>(entity =>
            {
                entity.HasKey(e => e.PersonStatus)
                    .HasName("PK__STATUSLOOKUP__288A248C");

                entity.ToTable("STATUSLOOKUP", "Person");

                entity.Property(e => e.PersonStatus).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<StudentAdvisees>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__StudentAdvisees__30EA6063");

                entity.ToTable("StudentAdvisees", "ARPT");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.Arptid).HasColumnName("ARPTID");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("fName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasColumnName("lName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ProgramName).HasColumnType("varchar(20)");

                entity.HasOne(d => d.Arpt)
                    .WithMany(p => p.StudentAdvisees)
                    .HasForeignKey(d => d.Arptid)
                    .HasConstraintName("FK__StudentAd__ARPTI__32DD95CD");

                entity.HasOne(d => d.ProgramNameNavigation)
                    .WithMany(p => p.StudentAdvisees)
                    .HasForeignKey(d => d.ProgramName)
                    .HasConstraintName("FK__StudentAd__Progr__612E7062");
            });

            modelBuilder.Entity<TeachingRole>(entity =>
            {
                entity.HasKey(e => e.TeachingRole1)
                    .HasName("PK_TEACHING_ROLE");

                entity.ToTable("TEACHING_ROLE", "Faculty");

                entity.Property(e => e.TeachingRole1)
                    .HasColumnName("TeachingRole")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Tenurelookup>(entity =>
            {
                entity.HasKey(e => e.TenureStatus)
                    .HasName("PK__TENURELOOKUP__302B4654");

                entity.ToTable("TENURELOOKUP", "Faculty");

                entity.Property(e => e.TenureStatus).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Termlookup>(entity =>
            {
                entity.HasKey(e => e.Term)
                    .HasName("PK__TERMLOOKUP__7D6ABC5D");

                entity.ToTable("TERMLOOKUP", "Faculty");

                entity.Property(e => e.Term).HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.HasKey(e => new { e.CaseUserId, e.Title1 })
                    .HasName("PK__Title__3D854172");

                entity.ToTable("Title", "Faculty");

                entity.HasIndex(e => new { e.Title1, e.CaseUserId })
                    .HasName("IDX_TITLE")
                    .IsUnique();

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Title1)
                    .HasColumnName("Title")
                    .HasMaxLength(100);

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasMaxLength(20);

                entity.Property(e => e.IsChair).HasColumnName("isChair");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Title)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Title__CaseUserI__3E7965AB");

                entity.HasOne(d => d.Title1Navigation)
                    .WithMany(p => p.TitleNavigation)
                    .HasForeignKey(d => d.Title1)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Title__Title__3F6D89E4");
            });

            modelBuilder.Entity<Titlelookup>(entity =>
            {
                entity.HasKey(e => e.Title)
                    .HasName("PK__TITLELOOKUP__32138EC6");

                entity.ToTable("TITLELOOKUP", "Faculty");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.IsAdminTitle).HasColumnName("isAdminTitle");
            });

            modelBuilder.Entity<Utilization>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__Utilization__0E95485F");

                entity.ToTable("Utilization", "Obsolete");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Comment).HasColumnType("varchar(max)");

                entity.Property(e => e.Dmdate)
                    .HasColumnName("DMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmid)
                    .HasColumnName("DMID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Semester).HasColumnType("varchar(10)");

                entity.Property(e => e.Uyear).HasColumnName("UYear");

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Utilization)
                    .HasForeignKey(d => d.CaseUserId)
                    .HasConstraintName("FK__Utilizati__CaseU__0F896C98");

                entity.HasOne(d => d.SemesterNavigation)
                    .WithMany(p => p.Utilization)
                    .HasForeignKey(d => d.Semester)
                    .HasConstraintName("FK__Utilizati__Semes__76298D48");
            });

            modelBuilder.Entity<Utilization1>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__Utilization__51D71E39");

                entity.ToTable("Utilization", "Faculty");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.AdminPts).HasColumnType("decimal");

                entity.Property(e => e.CaseUserId)
                    .HasColumnName("CaseUserID")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.ExpectedPts).HasColumnType("decimal");

                entity.Property(e => e.Notes).HasColumnType("varchar(max)");

                entity.Property(e => e.OtherPts).HasColumnType("decimal");

                entity.Property(e => e.PlusMinus)
                    .HasColumnType("decimal")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ResearchPts).HasColumnType("decimal");

                entity.Property(e => e.TeachingPts).HasColumnType("decimal");

                entity.Property(e => e.UtilizationPercent)
                    .HasColumnType("decimal")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UtilizationPts)
                    .HasColumnType("decimal")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.CaseUser)
                    .WithMany(p => p.Utilization1)
                    .HasForeignKey(d => d.CaseUserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Utilizati__CaseU__52CB4272");
            });

            modelBuilder.Entity<Web>(entity =>
            {
                entity.HasKey(e => e.PublicationId)
                    .HasName("PK__Web__77D1DE98");

                entity.ToTable("Web", "Publications");

                entity.Property(e => e.PublicationId)
                    .HasColumnName("PublicationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.WebPageTitle).HasColumnType("varchar(50)");

                entity.Property(e => e.WebSiteTitle)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Publication)
                    .WithOne(p => p.Web)
                    .HasForeignKey<Web>(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Web__Publication__78C602D1");
            });
        }
    }
}