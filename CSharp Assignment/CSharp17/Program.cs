using System;

namespace CSharp17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = -1;
            int p = 0;
            while (p < 5) //when user has played this game for 5 times, show a message to user you have played this game for 5 times.
            {
                try
                {
                    Console.WriteLine("Enter any number from 1-5:- \n ");  //1 Display following message to user: “Enter any number from 1-5"
                    string s = Console.ReadLine();
                    if (!input(s, 1, 5, 0, false))   //If user does not enter correct number from 1-5 show error message. and then -> GOTO step 1
                    {
                        n = -1;
                    }
                    else  //2 User enters an option from 1-5, show the exact message to user for the number selected
                    {
                        int.TryParse(s, out n);
                        p++;
                        if (n == 1)  // Enter Odd number
                        {
                            result("Enter Even number:- \n", n);
                        }
                        else if (n == 2)  //Enter Odd number
                        {
                            result("Enter Odd number:- \n", n);
                        }
                        else if (n == 3) // Enter a Prime number
                        {
                            result("Enter a Prime number:- \n", n);
                        }
                        else if (n == 4) // Enter a Negative number
                        {
                            result("Enter a Negative number:- \n", n);
                        }
                        else if (n == 5)  // Enter Zero
                        {
                            result("Enter Zero:- \n", n);
                        }
                    }
                }
                catch (InvalidNumberException ex)
                {
                    Console.WriteLine("Invalid Input!!\n" + ex.Message);
                    n = -1;
                }
            }
            Console.WriteLine("\nYou have played this game for 5 times.\n");
            Console.ReadLine();
        }
        static void result(string a, int c)
        {
            const int min1 = -1000000;
            const int max1 = 1000000;
            Console.WriteLine(a);
            string s = Console.ReadLine();
            if (input(s, min1, max1, 0, false))
            {
                if (input(s, min1, max1, c, true))
                {
                    Console.WriteLine("Success!! It is a correct number.");
                }
            }
        }
        static bool isPrimenumber(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;


            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
                if (n % i == 0)
                    return false;
            return true;
        }
        static bool input(string s, int min2, int max2, int c, bool b)
        {
            if (!b)
            {
                int n = -1;
                if (!int.TryParse(s, out n))
                {
                    throw new InvalidNumberException(string.Format("Error!! Enter any Integer Number from {0}-{1}.", min2, max2));
                }
                else
                {
                    if (n < min2 || n > max2)
                    {
                        throw new InvalidNumberException(string.Format("Error!! Enter any Number from {0}-{1}.", min2, max2));
                    }
                    return true;
                }
            }
            else
            {
                int n = -1;
                int.TryParse(s, out n);
                if (c == 1)
                {
                    if (n % 2 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidNumberException("\nIt is not an Even Number.\n");
                    }
                }
                if (c == 2)
                {
                    if (n % 2 == 1)
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidNumberException("\nIt is not an Odd number.\n");
                    }
                }
                if (c == 3)
                {
                    if (isPrimenumber(n))
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidNumberException("\nIt is not a Prime Number.\n");
                    }
                }
                if (c == 4)
                {
                    if (n < 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidNumberException("\nIt is not a Negative Number.\n");
                    }
                }
                if (c == 5)
                {
                    if (n == 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidNumberException("\nIt is not a Zero.\n");
                    }
                }
                return false;
            }
        }
    }
}