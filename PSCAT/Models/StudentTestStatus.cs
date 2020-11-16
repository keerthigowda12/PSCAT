using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Models
{

    [Table("StudentTestStatus")]
    public class StudentTestStatus
    {

        [Column("StaffId")]
        public string StaffId { get; set; }

        [Column("CourseId")]
        public string CourseId { get; set; }

        [Column("TestId")]
        public string TestId { get; set; }

        [Column("StudentId")]
        public string StudentId { get; set; }

        [Column("Completed")]
        public string Completed { get; set; }
    }
}
