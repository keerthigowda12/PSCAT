using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Models
{
    public class StudentScore
    {
        [Required]
        public string StudentID { get; set; }

        [Required]
        public string TestID { get; set; }

        [Required]
        [Display(Name = "Score")]
        public bool MarksScored { get; set; }
    }
}
