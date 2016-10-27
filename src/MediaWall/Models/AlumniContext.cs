using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MediaWall.Models
{
    public partial class AlumniContext : DbContext
    {
        public virtual DbSet<Alum> Alum { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=hawkeye-v.case.edu, 31338;Initial Catalog=Alumni;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alum>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PK_Person");

                entity.Property(e => e.Aid).HasColumnName("aid");

                entity.Property(e => e.Biography).HasColumnName("biography");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("fname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Graddate)
                    .HasColumnName("graddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDistinguished)
                    .HasColumnName("isDistinguished")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("lname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Maidenname)
                    .HasColumnName("maidenname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Mname)
                    .HasColumnName("mname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Photodate)
                    .HasColumnName("photodate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Alum)
                    .HasForeignKey(d => d.Cid)
                    .HasConstraintName("FK_Alum_Class");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Alum)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Person_Pictures");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK_Class");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Program)
                    .HasColumnName("program")
                    .HasMaxLength(150);

                entity.Property(e => e.Term)
                    .HasColumnName("term")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Class)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Class_Pictures");
            });

            modelBuilder.Entity<Pictures>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK_Pictures");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Alt).HasMaxLength(1000);

                entity.Property(e => e.Caption).HasMaxLength(1000);

                entity.Property(e => e.DisplayYear).HasColumnType("datetime");

                entity.Property(e => e.Filename).HasMaxLength(500);

                entity.Property(e => e.ImageLocation).IsRequired();

                entity.Property(e => e.ThumbnailAlt).HasMaxLength(1000);

                entity.Property(e => e.ThumbnailFilename).HasMaxLength(500);

                entity.Property(e => e.WallAlt).HasMaxLength(1000);

                entity.Property(e => e.WallFilename).HasMaxLength(500);

                entity.Property(e => e.WebAlt).HasMaxLength(1000);

                entity.Property(e => e.WebFilename).HasMaxLength(500);
            });
        }
    }
}