using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Models
{
    [Table("Questionaire")]
    public class Questionaire
    {
        [Column("CourseID")]
        public string CourseID { get; set; }

        [Column("QuestionID")]
        public int QuestionID { get; set; }

        [Column("Question")]
        public string Question { get; set; }

        [Column("Answer")]
        public string Answer { get; set; }

        [Column("Complexity")]
        public int Complexity { get; set; }

        [Column("Choice1")]
        public string Choice1 { get; set; }

        [Column("Choice2")]
        public string Choice2 { get; set; }

        [Column("Choice3")]
        public string Choice3 { get; set; }

        [Column("Choice4")]
        public string Choice4 { get; set; }

        [Column("Choice5")]
        public string Choice5 { get; set; }

        [Column("TestID")]
        public string TestID { get; set; }
    }
}
