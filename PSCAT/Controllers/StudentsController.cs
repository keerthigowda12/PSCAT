using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Tests()
        {
            return View();
        }
        public IActionResult ImproveMe()
        {
            return View();
        }
    }
}
