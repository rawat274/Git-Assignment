using System;
using System.Collections.Generic;

namespace CSharp7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Duck Assignment:-\n\n");
            List<Ducks> List1 = new List<Ducks>();
            int ch = 0;
            while (ch != 6)  //Enter the Choices.
            {
                Console.WriteLine("Enter your Choice:-\n");
                Console.WriteLine("1: Add a Duck.");
                Console.WriteLine("2: Remove a Duck.");
                Console.WriteLine("3: Remove all Ducks.");
                Console.WriteLine("4: Display Ducks in Icreasing order of their weight.");
                Console.WriteLine("5: Display Ducks in Increasing number of wings.");
                Console.WriteLine("6: Exit\n");
                if (!int.TryParse(Console.ReadLine(), out ch))
                {
                    Console.WriteLine("Enter a Correct Choice.\n");
                }
                else
                {
                    switch (ch)
                    {
                        case 1: //Add a Duck
                            AddDuck(List1);
                            break;
                        case 2: //Remove a Duck
                            RemoveDuck(List1);
                            break;
                        case 3: // Remove all Ducks
                            List1.Clear();
                            Console.WriteLine("All Ducks are Removed.\n");
                            break;
                        case 4: //Display Ducks in Icreasing order of their weight
                            DisplayAll(List1);
                            break;
                        case 5: //Display Ducks in Increasing number of wings.
                            IteratebyWings(List1);
                            break;
                        case 6: //Exit
                            break;
                        default: //default 
                            Console.WriteLine("Invalid Input!!");
                            break;
                    }

                }
            }
        }
        static void AddDuck(List<Ducks> List1)
        {
        start:
            Console.WriteLine("Enter the Duck you want to create 1(RedHead) or 2(Mallard) or 3(Rubber):- \n");
            if (int.TryParse(Console.ReadLine(), out int r))
            {
                if (r == Convert.ToInt32(DuckTypes.RedHead))
                {
                    var Obj1 = new RedHeadDuck();  //creating a Redhead duck object
                    Obj1.GetInfo();
                    List1.Add(Obj1);
                }
                if (r == Convert.ToInt32(DuckTypes.Mallard))
                {
                    var Obj2 = new MallardDuck();  //creating a Mallard duck object
                    Obj2.GetInfo();
                    List1.Add(Obj2);
                }
                if (r == Convert.ToInt32(DuckTypes.Rubberhead))
                {
                    var Obj3 = new RubberDuck();  //creating a Rubber duck object
                    Obj3.GetInfo();
                    List1.Add(Obj3);
                }
            }
            else
            {
                Console.WriteLine("Enter your Choice in the form of 1,2,or 3.\n");
                goto start;    //jump the control to start
            }
        }
        static void RemoveDuck(List<Ducks> List1)
        {
            if (List1.Count > 0)
            {
                DisplayAll(List1);
                int i;
                Console.WriteLine("Select the Duck you want to delete:- \n ");
                if (!int.TryParse(Console.ReadLine(), out i) || i < 0 || i > List1.Count)
                {
                    Console.WriteLine("\nSelect a Valid Duck.");
                }
                else
                {
                    Console.WriteLine("\nThe Duck deleted is:- \n");
                    List1[i - 1].Show();
                    List1.RemoveAt(i - 1);
                }
            }
            else
            {
                Console.WriteLine("\nThere are no Ducks in the list.");
            }
        }
        static void DisplayAll(List<Ducks> List1)
        {
            if (List1.Count > 1)
            {
                List1.Sort(delegate (Ducks a, Ducks b)
                {
                    return a.GetWeight().CompareTo(b.GetWeight());
                });
                foreach (Ducks dq in List1)
                {
                    dq.Show();
                    Console.WriteLine("\n\n");
                }
            }
            else { Console.WriteLine("There are no ducks in the list."); }
        }
        static void IteratebyWings(List<Ducks> List1)
        {
            if (List1.Count > 1)
            {
                List1.Sort(delegate (Ducks a, Ducks b)
                {
                    return a.GetWings().CompareTo(b.GetWings());
                });
                DisplayAll(List1);
            }
        }

    }
}