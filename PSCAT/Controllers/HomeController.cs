using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PSCAT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public object Db { get; private set; }

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
       

        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Login(LoginViewModel viewModel)
        {
            //connection string
            string myDb1ConnectionString = _configuration.GetConnectionString("myConn");
            GetData();
            if (viewModel.User.StartsWith("admin"))
            {
                 //Redirect("~/Home/TeacherPD");
            }
            else
            {
                //Redirect("~/Home/TeacherPD");
            }

            return (IActionResult)viewModel;
        }

        public DataTable GetData()
        {//connection string
            string myConn = _configuration.GetConnectionString("myConn");
            string str = "select LoginID, Password, UserType from Login";
            DataTable objresutl = new DataTable();
            try
            {
                SqlDataReader myReader;

                using (SqlConnection myCon = new SqlConnection(_configuration.GetConnectionString("myConn")))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(str, myCon))
                    {
                        myReader = myCommand.ExecuteReader();
                        
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return objresutl;

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
