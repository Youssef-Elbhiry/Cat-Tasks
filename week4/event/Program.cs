using System.Reflection.Metadata;

namespace week4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            DataProcessor d1 = new DataProcessor();
            d1.OnDataReceived += s1;
           d1.Receive("hi");


            #region write a program using an anonymous method to calculate the sum of an array of integers. --The anonymous method should take the array as a parameter and return
            //var del = delegate (int[] items)
            //{
            //    int sum = 0;
            //    foreach (var item in items)
            //    {
            //        sum += item;
            //    }
            //    return sum;
            //};
            
            //Console.WriteLine(del(new int[7] { 1, 2, 3, 4, 5, 6, 7 }));
            #endregion

        }
        public static void s1()
        {
            Console.WriteLine("Action taken");
        }
    }
    public class DataProcessor
    {
        public delegate void OnDataReceivedHandler();
        public event OnDataReceivedHandler OnDataReceived;

        public void Receive(string data)
        {
            Console.WriteLine("receiving....");
            OnDataReceived?.Invoke();
        }

    }
}
