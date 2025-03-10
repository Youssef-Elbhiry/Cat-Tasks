namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Prompts the user to enter 10 numbers and stores them in an array. Finds and prints the largest number in the array using a loop
            //int[] arr = new int[10];
            //int min = int.MaxValue;
            //Console.WriteLine("Enter 10 numbers:");
            //for (int i = 0; i < 10; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());

            //    if (arr[i] < min)
            //        min = arr[i];

            //}
            //Console.WriteLine($"Minmum = {min}");
            #endregion
            #region 2-Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant)
            //char c;
            //Console.WriteLine("Enter the charter:");
            // c = Convert.ToChar(Console.ReadLine());
            // c = char.ToLower(c);
            //switch(c)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //    case 'y':
            //        Console.WriteLine("Voiel");
            //        break;
            //    default:
            //        Console.WriteLine("Constant");
            //        break;
            //}
            #endregion
            #region 3- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Enter number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1;i<13;i++)
            //{
            //    Console.WriteLine($" {num} * { i } = {num * i}");
            //}

            #endregion
            #region 4-Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no 
            //int x;
            //x = Convert.ToInt32(Console.ReadLine());
            //if(x%3==0 && x%4==0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion
            #region 5- Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.WriteLine("enter number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int r,newnum = num;
            //string res = "";
            //while(newnum != 0)
            //{
            //    r = newnum % 2;
            //    newnum = newnum / 2;
            //    res = Convert.ToString( r) + res ;
            //}
            //Console.WriteLine(res);
            #endregion
            #region 6-Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int n;
            //Console.WriteLine("enter size:");
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //int[] arr2 = new int[n];
            //int[] arr3 = new int[2 * n];
            //Console.WriteLine("enter array1:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("enter array2:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr2[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < 2 * n; i++)
            //{
            //    if (i < n)
            //    {
            //        arr3[i] = arr[i];
            //    }
            //    else
            //    {
            //        arr3[i] = arr2[i-n];
            //    }

            //}
            //Array.Sort(arr3);
            //Console.WriteLine("result :");
            //for (int i = 0; i < 2 * n; i++)
            //{

            //    Console.WriteLine(arr3[i]);

            //}
            #endregion
            #region 7- Write a program in C# Sharp to find the second largest element in an array.
            //int n;
            //Console.WriteLine("enter size:");
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Array.Sort(arr);
            //Console.WriteLine(arr[n - 2]);
            #endregion
            #region 8- Write a Program to Print One Dimensional Array in Reverse Order
            //int n;
            //Console.WriteLine("enter size:");
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //int[] revarr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    revarr[n - i-1] = arr[i];
            //}
            //Console.WriteLine("Reversed array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(revarr[i]);
                
            //}
            #endregion
        }

    }
}
