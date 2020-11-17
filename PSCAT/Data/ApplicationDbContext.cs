using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PSCAT.Models;

namespace PSCAT.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentScore> StudentScores { get; set; }
        public DbSet<Tests> Tests { get; set; }
        public DbSet<StudentTestRecords> StudentTestRecords { get; set; }
        public DbSet<StudentTestStatus> StudentTestStatus { get; set; }
        public DbSet<StaffCourses> StaffCourses { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Questionaire> Questionaire { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentScore>().HasKey(key => new { key.StudentID, key.TestID });
            modelBuilder.Entity<Tests>().HasKey(key => new { key.TestID, key.CourseID, key.StaffID });
            modelBuilder.Entity<StudentTestRecords>().HasKey(key => new { key.StudentId, key.TestId, key.CourseId, key.QuestionId });
            modelBuilder.Entity<StudentTestStatus>().HasKey(key => new { key.StudentId, key.TestId, key.CourseId, key.StaffId });
            modelBuilder.Entity<StaffCourses>().HasKey(key => new { key.CourseID, key.StaffID });
            modelBuilder.Entity<Staff>().HasKey(key => new { key.StaffID });
            modelBuilder.Entity<Questionaire>().HasKey(key => new { key.TestID,key.QuestionID });

            base.OnModelCreating(modelBuilder);
        }
     }
}
