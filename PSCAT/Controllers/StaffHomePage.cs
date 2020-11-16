using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Controllers
{
    public class StaffHomePage : Controller
    {
        public IActionResult StaffPage()
        {
            return View();
        }
    }
}
