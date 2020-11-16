using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PSCAT.Models;
using PSCAT.ViewModels;
using PSCAT.Data;

namespace PSCAT.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            List<StudentScore> stu = _context.StudentScores.Where(s => s.StudentID == "student1").ToList();


            StudentDashboardViewModel testDetails = new StudentDashboardViewModel();
            testDetails.StudentId = "student1";

            foreach (StudentScore ts in stu)
            {
                var details = _context.Tests.Where(s => s.TestID == ts.TestID).FirstOrDefault();

                TestDetails temp = new TestDetails
                {
                    TestName = details.TestName,
                    TestId = ts.TestID,
                    Course = details.CourseID,
                    CourseId = details.CourseID,
                    Marks = ts.MarksScored.ToString(),
                    MaxMarks = details.MaxMarks.ToString(),
                    PassOrFail = ts.MarksScored >= Convert.ToInt32(details.CutOffMarks) ? "Y" : "N"
                };


                testDetails.TestDetail.Add(temp);

            }

            return View(testDetails);
        }

        public IActionResult TestDetails(string studentId, string testId, string courseId)
        {
            StudentTestRecords record = _context.StudentTestRecords.Where(s=>s.StudentId == studentId && s.TestId == testId && s.CourseId == courseId).FirstOrDefault();
            


            return View(record);
        }

        public IActionResult Tests()
        {
            List<StudentTestStatus> pendingTests = _context.StudentTestStatus.Where(s=>s.Completed == "N" && s.StudentId == "student1").ToList();

            TestStatusViewModel pendingTestCompleteDetails = new TestStatusViewModel();

            foreach(var rec in pendingTests)
            {
                var det = _context.Tests.Where(s=> s.TestID == rec.TestId && s.StaffID == rec.StaffId && s.CourseID == rec.CourseId).FirstOrDefault();

                var courseDet = _context.StaffCourses.Where(s=>s.CourseID == rec.CourseId && s.StaffID == rec.StaffId).FirstOrDefault();

                var staffDet = _context.Staff.Where(s=>s.StaffID == rec.StaffId).FirstOrDefault();

                StudentTestStatusRecord temp = new StudentTestStatusRecord();
                temp.CourseId = det.CourseID;
                temp.CourseName = courseDet.CourseName;
                temp.StaffId = det.StaffID;
                temp.StaffName = staffDet.StaffName;
                temp.StudentId = rec.StudentId;
                temp.Completed = rec.Completed;
                temp.TestId = rec.TestId;
                temp.TestName = det.TestName;



                pendingTestCompleteDetails.StudentTestStatusRecord.Add(temp);
            }


            return View(pendingTestCompleteDetails);
        }
        public IActionResult ImproveMe()
        {
            return View();
        }
    }
}
