using System;

namespace CSharp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Enter First Input is :- \n");   //Taking first input from user
                string i1 = Console.ReadLine();   //Taking second input from user
                Console.WriteLine("Enter Second Input is :- \n");
                string i2 = Console.ReadLine(); //Taking user's choice to compare by any of the method
                Console.WriteLine(" List of Methods to Compare User's Input \n 1. Using == method.\n 2. Using object.Equals method.\n 3. Using object.ReferenceEquals method.\n");
                Console.WriteLine("Enter your choice in the form 1,2 or 3 :- \n");
                var ch1 = Console.ReadLine();
                switch (Int16.Parse(ch1))
                {
                    case 1:  // Output after "==" method
                        var r1 = (i1 == i2);
                        Console.WriteLine("Result after comparing {0} and {1} by == method is :- \n{2}", i1, i2, r1);
                        break;
                    case 2: // Output after object.Equals method
                        var r2 = object.Equals(i1, i2);
                        Console.WriteLine("Result after comparing {0} and {1} by object.Equals method is :- \n {2}", i1, i2, r2);
                        break;
                    case 3: //Output after object.ReferenceEquals method
                        var r3 = Object.ReferenceEquals(i1, i2);
                        Console.WriteLine("Result after comparing {0} and {1} by object.ReferenceEquals method is :- \n {2}", i1, i2, r3);
                        break;
                    default:  // Default Choice
                        Console.WriteLine("Invalid Input!!");
                        break;
                }
                Console.WriteLine("Press 1 to continue or Press 0 to Terminate:- \n");  // Continuing after invalid input
                int ch2 = int.Parse(Console.ReadLine());
                if (ch2 == 1)  // Continue or Terminate
                    flag = false;
                else
                    flag = true;
            }

        }
    }
}