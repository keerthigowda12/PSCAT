using PSCAT.Data;
using PSCAT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Services
{
    public class CourseProcess
    {
        private  readonly ApplicationDbContext _context;
        public  CourseProcess(ApplicationDbContext context)
        {
            _context = context;
        }

        public CourseProcess getInstance()
        {
            return this;
        }
        public  List<StaffCourses> getCourses()
        {
            List<StaffCourses> staffcourses = _context.StaffCourses.ToList();
            return staffcourses;  
        }
    }
}
