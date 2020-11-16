using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Controllers
{
    public class UserHomePage : Controller
    {
        public IActionResult UserPage()
        {
            return View();
        }
    }
}
