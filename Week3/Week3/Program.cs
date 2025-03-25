using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Immutable;

namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create a generic method Swap<T> that swaps two variables of any type
            //int x = 10;
            //int y = 3;
            //Console.WriteLine($"x = {x} ,y = {y}");
            //Swap<int>(ref x, ref y);
            //Console.WriteLine($"x = {x} ,y = {y}");
            #endregion
            #region 2-Create a Dictionary<string, int> to store student names and their gradesWrite a function to find and display the grade of a student by name.

            //Dictionary<string, int> studentgrade = new Dictionary<string, int>();
            //studentgrade.Add("Ahmed", 60);
            //studentgrade.Add("Youssef", 100);
            //studentgrade.Add("Ali", 90);
            //studentgrade.Add("Mahmoud", 50);
            //studentgrade.Add("Abdo", 80);
            //Console.WriteLine(FindGrade(studentgrade, "Ai"));
            #endregion

            //Queue<string> CustomerService = new Queue<string>();
            //CustomerService.Enqueue("Ali");
            //CustomerService.Enqueue("Youssef");
            //CustomerService.Enqueue("Ahmed");
            //CustomerService.Enqueue("Mahmoud");
            //Serve(CustomerService);

        }
        #region 1-Create a generic method Swap<T> that swaps two variables of any type
        public static void Swap<T>( ref T var1, ref T var2)
        {
            T temp = var1;
            var1 = var2;
            var2 = temp;
        }
        #endregion

        #region 2-Create a Dictionary<string, int> to store student names and their gradesWrite a function to find and display the grade of a student by name.
        public static int? FindGrade(Dictionary<string , int> Database , string Name)
        {
            foreach(var student in Database)
            {
                if(student.Key == Name)
                    return Database[Name];
            }
            Console.WriteLine("Student not found");
            return null;

        }

        #endregion


        #region 3-Implement a Queue<string> to simulate a customer service lineAdd customers to the queue. Process them one by one, displaying their names as they are serve
             public static void Serve(Queue<string> customers)
        {
            while(customers.Count != 0)
            {
                Console.WriteLine($"{customers.Dequeue()} is served");
            }

        }
        #endregion
    }
}
