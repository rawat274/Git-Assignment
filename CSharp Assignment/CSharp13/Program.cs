using System;
using System.Collections.Generic;

namespace CSharp13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Numbers of elements in the list:- \n");
            int a = int.Parse(Console.ReadLine());  // Create a list of integers
            List<int> arr = new List<int>();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the Numbers in the list:- \n");
                int b = int.Parse(Console.ReadLine());
                arr.Add(b);
            }
            Console.WriteLine(arr.CustomAll(n => n > 1));
            Console.WriteLine(arr.CustomAny(n => n < 0));
            Console.WriteLine(arr.CustomMax(n => n * 2));
            Console.WriteLine(arr.CustomMin(n => n - 1));
            Console.WriteLine(string.Join(", ", arr.CustomWhere(n => n > 3)));
            Console.WriteLine(string.Join(", ", arr.CustomSelect(n => n + 1)));
        }
    }
}
