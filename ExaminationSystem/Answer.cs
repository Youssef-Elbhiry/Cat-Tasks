using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Answer
    {
        public char AnswerId { set; get; }
        public string AnswerText{ set; get; }

        public Answer(char id ,  string text)
        {
            AnswerId = id;
            AnswerText = text;
        }
        public override string ToString()
        {
            return $"{AnswerId}.{AnswerText}";
        }
    }
}
