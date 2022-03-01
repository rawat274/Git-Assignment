using System;
using System.Collections.Generic;

namespace CSharp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to find the prime numbers between two numbers.\n");
            var n = new List<int>();  // List to add the Prime Numbers
            Console.WriteLine("Enter the First Number:- \n ");  // Take the First Input
            int n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:- \n ");  // Take the Second Input
            int n2 = Int32.Parse(Console.ReadLine());
            if (n1 >= n2 || n1 < 2 || n2 > 1000)    // Checking the Inputs are within the range or not
            {
                Console.WriteLine("Invalid Input!!");
            }
            else
            {
                for (int i = n1; i <= n2; i++)    //Traverse the in the interval with the help of for loop
                {
                    bool flag = true;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        n.Add(i);
                    }
                }
            }
            if (n.Count > 0)  // Printing the List of Prime Numbers
            {
                Console.WriteLine("\n\nThe Prime Numbers from {0} and {1} in the range are:- \n\n{2}", n1, n2, string.Join(",", n));
            }
            else
            {
                Console.WriteLine("\n\n There are no Prime numbers in the range.");
            }
        }
    }
}
