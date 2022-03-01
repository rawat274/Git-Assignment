using System;

namespace CSharp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 For Immobile Equipment:- \n ");
            Console.WriteLine("Enter 2 For Mobile Equipment:- \n ");
            int r;
            if (!int.TryParse(Console.ReadLine(), out r) || r < 1 || r > 2)
            {
                Console.WriteLine("Invalid Input!!\n");
            }
            else if (r == 1)
            {
                Immobile obj1 = new Immobile();
                Console.WriteLine("Enter your Name:- \n");
                obj1.Name = Console.ReadLine();
                Console.WriteLine("Enter the description:- \n");
                obj1.Description = Console.ReadLine();
                obj1.DMTD = 0;
                obj1.mc = 0;
                Console.WriteLine("Enter the Distance:- \n ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Weight:- \n");
                int w = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" \n");
                Console.WriteLine("Showing Details For Mobile Equipment:- \n");
                obj1.MoveBy(d, w);
                Console.WriteLine(obj1.Name);
                Console.WriteLine(obj1.Description);
                Console.WriteLine(obj1.DMTD);
                Console.WriteLine(obj1.mc);
            }
            else
            {
                Mobile obj2 = new Mobile();
                Console.WriteLine("Enter your Name:- \n");
                obj2.Name = Console.ReadLine();
                Console.WriteLine("Enter the Description:- \n");
                obj2.Description = Console.ReadLine();
                obj2.DMTD = 0;
                obj2.mc = 0;
                Console.WriteLine("Enter the Distance:- \n");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Number of Wheels: \n");
                int w = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" \n");
                Console.WriteLine("Showing Details For Immobile Equipment:- \n");
                obj2.MoveBy(d, w);
                Console.WriteLine(obj2.Name);
                Console.WriteLine(obj2.Description);
                Console.WriteLine(obj2.DMTD);
                Console.WriteLine(obj2.mc);
            }
        }
    }
}
