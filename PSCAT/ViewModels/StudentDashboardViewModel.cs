using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PSCAT.Models;

namespace PSCAT.ViewModels
{
    public class StudentDashboardViewModel
    {

        public StudentDashboardViewModel()
        {
            TestDetail = new List<TestDetails>();
        }
        
        public List<TestDetails> TestDetail { get; set;}

        public string StudentId { get;set;}


    }

    public class TestDetails
    {
        public string TestName { get; set; }
        public string TestId { get; set; }
        public string Course { get; set; }
        public string CourseId { get; set; }
        public string Marks { get; set; }
        public string MaxMarks { get; set; }
        public string PassOrFail { get; set; }
    }

}
