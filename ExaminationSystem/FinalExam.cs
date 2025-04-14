using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numoq/*, List<Question> questions*/) : base(time, numoq)
        {
            //this.questions = questions;

        }

        public override void ShowExam()
        {
            foreach (var question in questions)
            {
                question.PrintQuestion();
                question.StudentAnswer = ReadAnswer();

                if (question.StudentAnswer == question.TrueAnswer)
                    GradeofExam += question.Mark;
                Console.ReadKey();
                Console.Clear();

            }

        }
        public override void PrintExamWithAnswers()
        {
            foreach (var question in questions)
            {
                question.PrintQuestion();

                Console.WriteLine($" Student Answer : {question.StudentAnswer}");
                Console.WriteLine($" True Answer : {question.TrueAnswer}");




            }
            Console.WriteLine($"Your grade is {GradeofExam}");
        }
        public override void ReadExamFromFile()
        {
            List<Question> questions = new List<Question>();
            StreamReader sr = new StreamReader("C:\\Users\\GHONIM\\OneDrive\\Desktop\\cat\\ExaminationSystem\\Exam.txt");
             if(sr.ReadLine() == "MCQ Questions")
            {
                string Firstline;

                while((Firstline = sr.ReadLine()) != "TF Questions")
                {
                    string[] line1 = Firstline.Split(' ');
                    string[] line2 = sr.ReadLine().Split('.');
                    string[] line3 = sr.ReadLine().Split('.');
                    string[] line4 = sr.ReadLine().Split('.');
                    string[] line5 = sr.ReadLine().Split('.');
                    char trueans = Convert.ToChar(sr.ReadLine());
                    var ans = new List<Answer>() { 
                    new Answer(Convert.ToChar(line2[0]),line2[1]),
                    new Answer(Convert.ToChar(line3[0]),line3[1]),
                    new Answer(Convert.ToChar(line4[0]),line4[1]),
                    new Answer(Convert.ToChar(line5[0]),line5[1]),
                    };

                    var question = new MCQQuestion(line1[0], line1[1], Convert.ToInt32(line1[2]), ans, trueans);
                    questions.Add(question);
                }
                while ((Firstline = sr.ReadLine()) != null)
                {
                    string[] line1 = Firstline.Split('-');
                    
                    char trueans = Convert.ToChar(sr.ReadLine());
                 

                    var question = new TFQuestion(line1[0], line1[1], Convert.ToInt32(line1[2]), trueans);
                    questions.Add(question);
                }


            }
            this.questions = questions;
        }
        //public void ReadExamFromConsole()
        //{

        //}



    }
}
