using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Models
{
    [Table("StudentScores")]
    public partial class StudentScore
    {
        [Column("StudentID", Order = 1, TypeName = "nchar(10)")]
        public string StudentID { get; set; }

        [Column("TestID", Order = 2, TypeName = "nchar(10)")]
        public string TestID { get; set; }

        [Display(Name = "Score")]
        [Column("MarksScored", Order = 3, TypeName = "numeric(18,0)")]
        public int MarksScored { get; set; }
    }
}
