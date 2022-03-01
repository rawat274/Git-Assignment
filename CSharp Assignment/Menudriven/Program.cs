using System;

namespace Menudriven
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the CSharp Assignment:- \n");
            Console.WriteLine("Enter 1 for Program 1.");
            Console.WriteLine("Enter 2 for Program 2.");
            Console.WriteLine("Enter 3 for Program 3.");
            Console.WriteLine("Enter 4 for Program 4.");
            Console.WriteLine("Enter 5 for Program 5.");
            Console.WriteLine("Enter 6 for Program 6.");
            Console.WriteLine("Enter 7 for Program 7.");
            Console.WriteLine("Enter 8 for Program 8.");
            Console.WriteLine("Enter 9 for Program 9.");
            Console.WriteLine("Enter 10 for Program 10.");
            Console.WriteLine("Enter 11 for Program 11.");
            Console.WriteLine("Enter 12 for Program 12.");
            Console.WriteLine("Enter 13 for Program 13.");
            Console.WriteLine("Enter 14 for Program 14.");
            Console.WriteLine("Enter 15 for Program 15.");
            Console.WriteLine("Enter 16 for Program 16.");
            Console.WriteLine("Enter 17 for Program 17.");
            Console.WriteLine("Enter 18 to Exit.");
            Console.WriteLine("Enter your Choice:- \n");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    CSharp1.Program.Main(args);
                    break;
                case 2:
                    CSharp2.Program.Main(args);
                    break;
                case 3:
                    CSharp3.Program.Main(args);
                    break;
                case 4:
                    CSharp4.Program.Main(args);
                    break;
                case 5:
                    CSharp5.Program.Main(args);
                    break;
                case 6:
                    CSharp6.Program.Main(args);
                    break;
                case 7:
                    CSharp7.Program.Main(args);
                    break;
                case 8:
                    CSharp8.Program.Main(args);
                    break;
                case 9:
                    CSharp9.Program.Main(args);
                    break;
                case 10:
                    CSharp10.Program.Main(args);
                    break;
                case 11:
                    CSharp11.Program.Main(args);
                    break;
                case 12:
                    CSharp12.Program.Main(args);
                    break;
                case 13:
                    CSharp13.Program.Main(args);
                    break;
                case 14:
                    CSharp14.Program.Main(args);
                    break;
                case 15:
                    CSharp15.Program.Main(args);
                    break;
                case 16:
                    CSharp16.Program.Main(args);
                    break;
                case 17:
                    CSharp17.Program.Main(args);
                    break;
                case 18:
                    break;
                default:
                    Console.WriteLine("Invalid Input!!");
                    break;
            }
        }
    }
}








