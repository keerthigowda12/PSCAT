using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PSCAT.Data;
using PSCAT.Models;

namespace PSCAT.Services
{
    public class TeacherPD
    {
        private readonly ApplicationDbContext _context;
        public TeacherPD(ApplicationDbContext context)
        {
            _context = context;
        }
       /* public TeacherPD()
        {

        } */
        public Boolean saveQuestion(QuestionAns qans)
        {
            String questData = (@"insert into Questionaire(COURSE_ID,QUESTION,ANSWER,COMPLEXITY,Choice1,Choice2,Choice3,Choice4,Choice5,TestID)
                 values('"+qans.course+"','"+qans.question+"','"+qans.choice1+ "','" + qans.choice2 + "','" + qans.choice3 + "','"+ qans.choice4 +"',NULL,NULL)");
            //int i=DBUtil.SaveDetails(questData);
            Questionaire qnst = new Questionaire()
            { CourseID = qans.course,
                         QuestionID = 1,
                        Question = qans.question, 
                        Answer = qans.choice1, 
                        Complexity = (int)qans.complexity, 
                        Choice1 = qans.choice1, 
                        Choice2 = qans.choice2, 
                        Choice3 = qans.choice3, 
                        Choice4 = qans.choice4,

                    };

            _context.Questionaire.Add(qnst);
            int i=_context.SaveChanges();

            if (i > 0)
                return true;
            else
                return false;
        }
    }
}
