using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PSCAT.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Login(LoginViewModel viewModel)
        {
            if (viewModel.User == "admin")
            {
                 //Redirect("~/Home/TeacherPD");
            }
            else
            {
                //Redirect("~/Home/TeacherPD");
            }

            return (IActionResult)viewModel;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
