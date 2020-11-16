using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Models
{
    [Table("StudentTestRecords")]
    public class StudentTestRecords
    {
        [Column("StudentId")]
        public string StudentId { get; set; }

        [Column("TestId")]
        public string TestId { get; set; }

        [Column("CourseId")]
        public string CourseId { get; set; }

        [Column("QuestionId")]
        public string QuestionId { get; set; }

        [Column("StudentAnswer")]
        public string StudentAnswer { get; set; }

        [Column("Question")]
        public string Question { get; set; }

        [Column("Evaluated")]
        public string Evaluated { get; set; }

        [Column("TestStatus")]
        public string TestStatus { get; set; }
    }
}
