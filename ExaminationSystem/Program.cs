namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            string TeacherPass = "1234";
            int Choice;
            Exam exam = null;
            while (true)
            {
                Console.WriteLine("1) Teacher Mode");
                Console.WriteLine("2) Student Mode");
                Choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
                if (Choice == 1)
                {
                    string Pass="",name="";
                    Console.Write("Enter Your Name:");
                    name = Console.ReadLine();
                    Console.Write("Enter Your Password:");
                    Pass = Console.ReadLine();

                  if(Pass == TeacherPass)
                    {
                        Console.WriteLine("Access Granted.");
                        Console.Clear();
                    
                            Console.WriteLine("Select option:");
                            Console.WriteLine("Select type of exam:");
                            Console.WriteLine("1) Practical");
                            Console.WriteLine("2) Final");
                            Console.Write("Enter your choice:");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            List<Question> questions;
                            if (choice == 1)
                            {
                                Subject Math = new Subject(1, "Math");
                                //var ansers =  new List<Answer>(   )
                                //{ new Answer('a', "2"),
                                //new Answer('b', "1"),
                                //new Answer('c', "-1"),
                                //new Answer('d', "9") };
                                // questions = new List<Question>( )
                                // {
                                //     new MCQQuestion("Q1", "1+1", 1, ansers , 'b'),
                                //     new MCQQuestion("Q2", "-2+1", 1, ansers, 'c')
                                // };
                                exam = Math.CreatExam(Type.Practical, 20, 1);


                            }
                            else if (choice == 2)
                            {
                                Subject Math = new Subject(1, "Math");
                                // var ansers = new List<Answer>()
                                //{ new Answer('a', "2"),
                                //new Answer('b', "1"),
                                //new Answer('c', "-1"),
                                //new Answer('d', "9") };
                                // questions = new List<Question>() {
                                // new MCQQuestion("Q1","1+1",2,ansers,'a'),
                                // new MCQQuestion("Q2","1*1",1,ansers,'b'),
                                // new TFQuestion("Q3","Fish lives in water?",1,'a')



                                // };
                                exam = Math.CreatExam(Type.Final, 100, 3);


                            }
                        
                       

                    }
                  else
                    {
                        Console.WriteLine("Access Denied.");
                    }

                }
                else if(Choice == 2)
                {
                    Console.Write("Enter your id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    if(exam == null)
                    { Console.WriteLine("No available exam");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        exam.ShowExam();
                        exam.PrintExamWithAnswers();
                        Console.ReadKey();
                        Console.Clear();
                    }

                }
            }
        }
        
    }
}
