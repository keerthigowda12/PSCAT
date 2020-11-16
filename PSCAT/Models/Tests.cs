using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Models
{
    [Table("Tests")]
    public partial class Tests
    {
        [Column("TestID")]
        public string TestID { get; set; }

        [Column("CourseID")]
        public string CourseID { get; set; }

        [Column("StaffID")]
        public string StaffID { get; set; }

        [Column("TestName")]
        public string TestName { get; set; }

        [Column("MaxMarks")]
        public int MaxMarks { get; set; }

        [Column("CutOffMarks")]
        public int CutOffMarks { get; set; }

        [Column("Duration")]
        public int Duration { get; set; }
    }
}
