using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Question : IComparable<Question>
    {
        public string HeaderoftheQuestion { set; get; }
        public string BodyoftheQuestion { set; get; }
        public int Mark { set; get; }

        public char TrueAnswer { get; set; }
        public char StudentAnswer { get; set; }

        public Question(string header, string body , int mark)
        {
            HeaderoftheQuestion = header;

            BodyoftheQuestion = body;

            Mark = mark;
        }
        public abstract void PrintQuestion();

        //public abstract void ReadQuestion();

        public int CompareTo(Question? other)
        {
            return this.TrueAnswer.CompareTo(other.TrueAnswer);
        }
    }
}
