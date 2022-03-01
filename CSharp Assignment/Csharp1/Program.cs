using System;

namespace CSharp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n;
            bool flag = false;
            while (!flag)
            {
                try
                {
                    Console.WriteLine("Enter your Choice to convert :- \n Press 1 and Enter for Integer \n Press 2 and Enter for Float \n Press 3 and Enter for Boolean. \n");
                    var i1 = Console.ReadLine();
                    Console.WriteLine("\n");
                    n = Convert.ToInt32(i1);
                    Console.WriteLine("Enter the Choice to be converted:- \n");
                    var i2 = Console.ReadLine();

                    switch (n)
                    {
                        case 1:
                            Console.WriteLine(" List of Methods to Convert to Integer \n a. Using Int.Parse method.\n b. Using Convert.ToInt method.\n c. Using Int.TryParse method.\n Enter your choice in the form of a, b or c:- \n");
                            var ch1 = Console.ReadLine();
                            switch (Char.Parse(ch1))
                            {
                                case 'a':
                                    int ci1 = Int32.Parse(i2);
                                    Console.WriteLine("Converted Integer Value is:- \n {0}", ci1);
                                    break;
                                case 'b':
                                    int ci2 = Convert.ToInt32(i2);
                                    Console.WriteLine("Converted Integer Value is:- \n {0}", ci2);
                                    break;
                                case 'c':
                                    short num;
                                    bool ci3 = Int16.TryParse(i2, out num);
                                    Console.WriteLine("Converted Integer Value is:- \n {0}", num);
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input!!");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine(" List of Methods to convert to float  \n a. Using Single.Parse method.\n b. Using Float.Parse method.\n c. Using Convert.ToSingle method.\n Enter your choice in the form of a, b or c:- \n");
                            var ch2 = Console.ReadLine();
                            switch (Char.Parse(ch2))
                            {
                                case 'a':
                                    float cf1 = Single.Parse(i2);
                                    Console.WriteLine("Converted Float Value is :- \n {0}", cf1);
                                    break;
                                case 'b':
                                    float cf2 = float.Parse(i2);
                                    Console.WriteLine("Converted Float Value is :- \n {0}", cf2);
                                    break;
                                case 'c':
                                    float cf3 = Convert.ToSingle(i2);
                                    Console.WriteLine("Converted Float Valueiis :- \n {0}", cf3);
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input!!");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine(" List of Methods to convert to bool \n a. Using Convert.toBoolean method.\n b. Using Boolean.TryParse method.\n c. Using bool.Parse method.\n Enter your choice in the form of a, b or c:- \n");
                            var ch3 = Console.ReadLine();
                            switch (Char.Parse(ch3))
                            {
                                case 'a':
                                    bool cb1 = Convert.ToBoolean(i2);
                                    Console.WriteLine("Converted Boolean Value is :- \n {0}", cb1);
                                    break;
                                case 'b':
                                    bool cb2 = Boolean.TryParse(i2, out bool result);
                                    Console.WriteLine("Converted Boolean Value is :- \n {0}", result);
                                    break;
                                case 'c':
                                    bool cb3 = bool.Parse(i2);
                                    Console.WriteLine("Converted Boolean Value is :- \n {0}", cb3);
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input!!");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong Choice!!");
                            break;
                    }
                    Console.WriteLine("Press 1 to run the Program again or Press 0 to Terminate:- \n");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (x == 1)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong Choice!!\n");
                }
            }
        }
    }
}

