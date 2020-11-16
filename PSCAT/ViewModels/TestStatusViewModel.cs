using PSCAT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.ViewModels
{
    public class TestStatusViewModel
    {
        public TestStatusViewModel()
        {
            StudentTestStatusRecord = new List<StudentTestStatusRecord>();
        }

        public List<StudentTestStatusRecord> StudentTestStatusRecord { get; set; }





    }

    public class StudentTestStatusRecord
    {

        public string StaffId { get; set; }
        public string StaffName { get; set; }

        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public string TestId { get; set; }

        public string TestName { get; set; }

        public string StudentId { get; set; }

        public string Completed { get; set; }
    }
}
