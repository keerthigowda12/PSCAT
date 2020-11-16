using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Models
{
    [Table("StaffCourses")]
    public class StaffCourses
    {
        [Column("CourseName")]
        public string CourseName { get; set; }

        [Column("CourseID")]
        public string CourseID { get; set; }

        [Column("StaffID")]
        public string StaffID { get; set; }
    }
}
