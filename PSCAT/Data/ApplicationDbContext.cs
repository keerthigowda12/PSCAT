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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentScore>().HasKey(key => new { key.StudentID, key.TestID });
            modelBuilder.Entity<Tests>().HasKey(key => new { key.TestID, key.CourseID, key.StaffID });
            modelBuilder.Entity<StudentTestRecords>().HasKey(key => new { key.StudentId, key.TestId, key.CourseId, key.QuestionId });

            base.OnModelCreating(modelBuilder);
        }
     }
}
