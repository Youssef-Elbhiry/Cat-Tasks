using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class MCQQuestion : Question
    { 
        List<Answer> Answers = new List<Answer>();
        
        public MCQQuestion(string header, string body, int mark , List<Answer> answers , char trueanswer) : base(header, body, mark)
        {
            TrueAnswer = trueanswer;
            Answers = answers;
        }
        
        public override void PrintQuestion()
        {
            Console.WriteLine($"{HeaderoftheQuestion} {BodyoftheQuestion}");

            foreach (var answer in Answers)
            {
                Console.WriteLine(answer);  
            }

            
        }
    }
}
