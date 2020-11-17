using Microsoft.AspNetCore.Mvc;
using PSCAT.Data;
using PSCAT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Controllers
{
    public class TestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult StartTest(string studentId, string testId, string courseId, string staffId)
        {
            List<Questionaire> questions = _context.Questionaire.Where(s=>s.TestID == testId).ToList();

            return View(questions);
        }



    }
}
