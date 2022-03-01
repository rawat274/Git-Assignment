using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp12
{
    public class Program
    {
        public static void PrintNumbers(string s, IEnumerable<int> list)
        {
            Console.WriteLine(s + " :-    \n");
            foreach (int n in list)
                Console.WriteLine(n + "  ");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Numbers of elements in the list:- \n");
            int a = int.Parse(Console.ReadLine());  // Create a list of integers
            List<int> list = new List<int>();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the Numbers in the list:- \n");
                int b = int.Parse(Console.ReadLine());
                list.Add(b);
            }
            IEnumerable<int> n1 = list.Where(x => x % 2 == 1);  // Find odd - Lambda Expression – without curly brackets
            PrintNumbers("Odd Numbers", n1);
            IEnumerable<int> n2 = list.Where(x => { return x % 2 == 0; });   // Find Even - Lambda Expression – with curly brackets
            PrintNumbers("Even numbers", n2);
            IEnumerable<int> n3 = list.Where(delegate (int x)  // Find Prime – Anonymous Method
            {
                if (x <= 1)
                    return false;
                for (int i = 2; i <= x / 2; i++)
                    if (x % i == 0)
                        return false;
                return true;
            });
            PrintNumbers("Prime Numbers", n3);
            IEnumerable<int> n4 = list.Where(x => // Find Prime Another – Lambda Expression
            {
                if (x <= 1)
                    return false;
                for (int i = 2; i <= x / 2; i++)
                    if (x % i == 0)
                        return false;
                return true;
            });
            PrintNumbers("Prime Numbers Another Using Lambda", n4);
            Func<int, bool> n5 = GreaterThanFive;   // Elements Greater Than Five – Method Group Conversion Syntax Func<T,TResult> is a delegate
            IEnumerable<int> list1 = list.Where(n5);
            PrintNumbers("Greater Than Five", list1);
            Func<int, bool> n6 = new Func<int, bool>(LessThanFive);  // Less than Five – Delegate Object in Where – Method Group Conversion Syntax in Constructor of Object
            IEnumerable<int> list2 = list.Where(n6);
            PrintNumbers("Less Than Five", list2);
            Func<int, bool> n7 = new Func<int, bool>(x => x % 3 == 0); // Find 3k – Delegate Object in Where – Lambda Expression in Constructor of Object
            IEnumerable<int> list3 = list.Where(n7);
            PrintNumbers("3k", list3);
            Func<int, bool> n8 = new Func<int, bool>(delegate (int x) // Find 3k + 1 - Delegate Object in Where – Anonymous Method in Constructor of Object
            {
                return x % 3 == 1;
            });
            IEnumerable<int> list4 = list.Where(n8);
            PrintNumbers("3k + 1", list4);
            Func<int, bool> n9 = x => x % 3 == 2; // Find 3k + 2 - Delegate Object in Where – Lambda Expression Assignment
            IEnumerable<int> list5 = list.Where(n9);
            PrintNumbers("3k + 2", list5);
            Func<int, bool> n10 = delegate (int x) // Find anything - Delegate Object in Where – Anonymous Method Assignment
            {
                return x != 0;
            };
            IEnumerable<int> list6 = list.Where(n10);
            PrintNumbers("Anything", list6);
            Func<int, bool> n11 = AnythingMethod; // Find anything - Delegate Object in Where – Method Group Conversion Assignment
            IEnumerable<int> list7 = list.Where(n11);
            PrintNumbers("Anything Another", list7);

        }
        public static bool GreaterThanFive(int x)
        {
            return x > 5;
        }
        public static bool LessThanFive(int x)
        {
            return x < 5;
        }
        public static bool AnythingMethod(int x)
        {
            return x != 0;
        }

    }
}
