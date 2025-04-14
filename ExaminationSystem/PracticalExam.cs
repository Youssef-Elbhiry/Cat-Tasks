using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class PracticalExam : Exam
    { public int GradeofExam = 0;
        public PracticalExam(int time, int numoq):base(time , numoq)
        {
            
        }

        public override void ShowExam()
        {
            foreach (var question in questions)
            {
                question.PrintQuestion();
                // Console.WriteLine($" True Answer : {question.TrueAnswer}");
                question.StudentAnswer = ReadAnswer();

                if (question.StudentAnswer == question.TrueAnswer)
                    GradeofExam += question.Mark;
                Console.ReadKey();
                Console.Clear();

            }

        }
        public override void PrintExamWithAnswers()
        {
            Console.WriteLine("Exam answers:");
            foreach (var question in questions)
            {
               


                
                Console.WriteLine($" {question.HeaderoftheQuestion}: {question.TrueAnswer}");




            }
            Console.WriteLine($"Your grade is {GradeofExam}");
        }


        public override void ReadExamFromFile()
        {
            List<Question> questions = new List<Question>();
          
            string[] text = File.ReadAllLines("C:\\Users\\GHONIM\\OneDrive\\Desktop\\cat\\ExaminationSystem\\Exam.txt");

            for(int i = 0;i< text.Length;i+=6)
            {
                string[] line1 = text[i].Split(' ');
                string[] line2 = text[i+1].Split('.');
                string[] line3 = text[i+2].Split('.');
                string[] line4 = text[i+3].Split('.');
                string[] line5 = text[i+4].Split('.');
                char trueans = Convert.ToChar(text[i + 5]);
                List<Answer> ans = new List<Answer>() { 
                new Answer(Convert.ToChar(line2[0]) ,line2[1] ),
                new Answer(Convert.ToChar(line3[0]) ,line3[1] ),
                new Answer(Convert.ToChar(line4[0]) ,line4[1] ),
                new Answer(Convert.ToChar(line5[0]) ,line5[1] )
                };
                Question question = new MCQQuestion(line1[0], line1[1], Convert.ToInt32(line1[2]), ans, trueans);
                questions.Add(question);

            }

            this.questions= questions;
        }
     
    }
}
