using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PSCAT.Models;
using PSCAT.Services;
using PSCAT.Data;

namespace PSCAT.Controllers
{
    public class TeacherPDController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TeacherPDController(ApplicationDbContext context)
        {
            _context = context;
        }
        private TeacherPD tps;
        public IActionResult TeacherPD()
        {
            return View();
        }

        public IActionResult Questionnaire()
        {
            CourseProcess courseprocess = new CourseProcess(_context);
            QuestionAns questionnaire = new QuestionAns();
            questionnaire.staffcourses = courseprocess.getCourses();
            return View(questionnaire);
        }

        public IActionResult Review()
        {
            return View();
        }
        public IActionResult QuestionAnsSub(QuestionAns qAns)
        {
            tps = new TeacherPD();

             Boolean saveStatus= tps.saveQuestion(qAns);
             if (saveStatus == true)
                 return View("success");
             else
                 return View("failToSave"); 

        }

    }

}
