using System;

namespace CSharp11
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number for Checking Odd, Even and Prime Number:- \n");
            var n = int.Parse(Console.ReadLine());
            bool n1 = n.CheckisOddNumber();
            Console.WriteLine("Odd Number are :- \n" + n1);
            bool n2 = n.CheckisEvenNumber();
            Console.WriteLine("Even Number  are :- \n" + n2);
            bool n3 = n.CheckisPrimeNumber();
            Console.WriteLine("Prime Number are :- \n" + n3);
            Console.WriteLine("Enter the Number for Checking if the Number is Divisible:- \n");
            int d = int.Parse(Console.ReadLine());
            bool n4 = n.CheckisDivisibleBy(d);
            Console.WriteLine("The Number is Divisible By :- {0} \n", n4);
        }
    }
}
