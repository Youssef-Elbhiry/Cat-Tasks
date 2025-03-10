using System.Globalization;

namespace week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                Name = "youssef sami",
                ID = 1,
                Gender = "male",
                SecurityLevel = Privilege.Developer,
                HireDate = "1/1/2003",
                Salary = 2500.7

            };


            Console.WriteLine(e1.ToString());
        }

      

        


    }


    #region 1
    public class student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Name:{Name}  Age:{Age}  Grade:{Grade}");
        }
    }


    public class PostGraduate : student
    {


    }
    #endregion

    #region 2
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; } 

        public string HireDate;

        public Privilege SecurityLevel;

        private string gender;
        public string Gender {
            get
            {
                return gender;
            }
            set
            {
                if(value == "male" || value == "female")
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("wrong gender!");
                }
            }
        }

        public override string ToString()
        {
            return $"Name:{Name} ID:{ID}  Salary:{String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}  Gender:{Gender}  Security Level:{SecurityLevel}  Hire Date:{HireDate}";
        }
    } 
   
   public enum Privilege
    {
        guest,
        Developer,
        secretary ,
        DBA
    }
    #endregion
}
