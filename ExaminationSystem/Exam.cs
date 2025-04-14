using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
     public abstract class Exam
    {
        
        public int TimeofExam { set; get; }
        public int NumberofQuestions{ set; get; }

        public int GradeofExam = 0;
        public List<Question> questions { get; set; } = new List<Question>();
        public Exam(int time , int numofquestion)
        {   
            if (time <= 0 && numofquestion <= 0)
                throw new ArgumentException("Time and number of question must be postive number");

            TimeofExam = time;
            NumberofQuestions = numofquestion;
        }
        public abstract void ShowExam();
        public abstract void PrintExamWithAnswers();

        public char ReadAnswer()
        {
            Console.Write("Enter Your Answer:");
            return Convert.ToChar(Console.ReadLine());
        }
        public abstract void ReadExamFromFile();

  
    }
}
