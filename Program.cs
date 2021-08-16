using System;
using System.IO;

namespace Assignment_On_Basic_Course
{
    class Program
    {
        static int GetCount(int[] arr, int number)
        {
            int count = 0;
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            /*
             * Write a C# code to read an array of integers from a text file e.g.
             * {10, 30, 30, 10, 20, 40, 10} - and find the number of pairs of a number 
             * given by the user through the console. Display the result on the console.
 * 
             * */
            var path = @"C:\Users\godseh\OneDrive - Lenze SE\Desktop\C#_Training\Assignments_By_Lenze\My_TXT_File.txt";
            var file = File.ReadAllText(path);

            file = file.Substring(1, file.Length-2);

            string[] str = file.Split(',');

            int[] arr = new int[str.Length];
            int i = 0;
            foreach(string num in str)
            {
                arr[i++] = Convert.ToInt32(num.Trim());
            }

            Console.WriteLine("File contents are :");
            foreach (int num in arr)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();


            Console.WriteLine("Enter a no. to find its pair press -1 to stop ");

            while(true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == -1)
                    break;
                int count = GetCount(arr, num);
                Console.WriteLine("Pairs of this numbers :"+(count/2));
            }



            
        }
    }
}
