using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class TFQuestion : Question
    {
       
        Answer[] Answers = new Answer[2] {new Answer('a' , "True"), new Answer('b', "False") };
       

        public TFQuestion(string header, string body, int mark , char trueanswer ) : base(header, body, mark)
        {
            TrueAnswer = trueanswer;
        }

      
        public override void PrintQuestion()
        {
            Console.WriteLine($"{HeaderoftheQuestion} {BodyoftheQuestion}");

            Console.Write(Answers[0]);
            Console.WriteLine($"\t\t\t {Answers[1]}");
        }
    }
}
