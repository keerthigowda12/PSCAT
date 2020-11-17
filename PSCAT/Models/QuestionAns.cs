using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PSCAT.Models
{
    public class QuestionAns
    {

        [Display(Name = "Question")]
        [Required(ErrorMessage = "Question is required")]
        public string question{ get; set; }
        [Display(Name = "Answer  ")]
        [Required(ErrorMessage = "Answer is required")]
        public string choice1 { get; set; }
        [Display(Name = "Option-1")]
        public string choice2 { get; set; }
        [Display(Name = "Option-2")]
        public string choice3 { get; set; }
        [Display(Name = "Option-3")]
        public string choice4 { get; set; }

        [Required(ErrorMessage ="Please select one item")]
        public string course { get; set; }

        public List<StaffCourses> staffcourses { get; set; }

        [Required(ErrorMessage = "Complexity required")]
        public Complexity complexity { get; set; }

    }
}
