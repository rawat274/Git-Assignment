using System;

namespace CSharp5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IShowDetail[] ducks = new IShowDetail[3];  //Create ducks
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, i = 0;
            Console.WriteLine("Enter the weight for Rubber Duck:- \n");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number of wings for Rubber Duck:- \n");
            b = int.Parse(Console.ReadLine());
            ducks[0] = new RubberDuck(a, b, DuckType.Rubber);
            Console.WriteLine("Enter the weight for Mallard Duck:- \n");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number of wings for Mallard Duck:- \n");
            d = int.Parse(Console.ReadLine());
            ducks[1] = new MallardDuck(c, d, DuckType.Mallard);
            Console.WriteLine("Enter the weight for Redhead Duck:- \n");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number of wings for Redhead Duck:- \n");
            f = int.Parse(Console.ReadLine());
            ducks[2] = new RedheadDuck(e, f, DuckType.Redhead);
            Console.WriteLine("Enter your Choice:- \n");
            i = int.Parse(Console.ReadLine());
            if (i == 0)   //Show details of a duck, i.e. when you call for e.g. ShowDetails() method of a duck, duck should print its traits.
            {
                Console.WriteLine("The Traits of Rubber Duck:- \n");
                ducks[0].ShowDetails();

            }
            else if (i == 1)
            {
                Console.WriteLine("The Traits of Mallard Duck:- \n");
                ducks[1].ShowDetails();
            }
            else if (i == 2)
            {
                Console.WriteLine("The Traits of Redhead Duck:- \n");
                ducks[2].ShowDetails();
            }
            else
            {
                Console.WriteLine("Wrong Choice!!");
            }
        }
    }
}

