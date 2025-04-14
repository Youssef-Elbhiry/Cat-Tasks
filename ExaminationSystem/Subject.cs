using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Subject
    {
       public int SubjectId { set; get; }
       public string SubjectName{ set; get; }

        public Exam ExamofTheSubject { set; get; } 


        public Subject(int id , string name)
        {
            SubjectId = id;
            SubjectName = name;

        }

        public Exam CreatExam(Type type , int time ,int noq )
        {
            Exam exam;
            if(type == Type.Final)
            {
                exam = new FinalExam(time , noq );
                exam.ReadExamFromFile();
            }
            else if (type == Type.Practical)
            {
                exam = new PracticalExam(time, noq);
                exam.ReadExamFromFile();
            }
            else { exam = null; }

            ExamofTheSubject = exam ;

            return exam;


        }






    }
}
