using System;

namespace CSharp9
{
    public class Program
    {
        public static void Main(string[] args)
        {

            PriorityQueue2<Shoppinglist> list1 = new PriorityQueue2<Shoppinglist>();
            Shoppinglist s1 = new Shoppinglist("Apple", 1.0);
            Shoppinglist s2 = new Shoppinglist("Bread", 2.0);
            Shoppinglist s3 = new Shoppinglist("Milk", 3.0);
            Shoppinglist s4 = new Shoppinglist("Cereals", 4.0);
            Shoppinglist s5 = new Shoppinglist("Eggs", 6.0);
            Shoppinglist list2;
            list1.Enqueue(s1);
            list1.Enqueue(s2);
            list1.Enqueue(s3);
            list1.Enqueue(s4);
            list1.Enqueue(s5);
            list1.Printlist();
            while (true)
            {
                 Console.WriteLine("Enter 1 for Enqueue.");
                 Console.WriteLine("Enter 2 for Dequeue");
                 Console.WriteLine("Enter 3 for Size of Queue");
                 Console.WriteLine("Enter 4 to check the items in the Shopping List is in the Queue.");
                 Console.WriteLine("Enter 5 to Print the Queue.");
                 Console.WriteLine("Enter 6 to get the highest Priority item in the Shopping List .");
                 Console.WriteLine("Enter 7 to Exit.");
                int ch;
                if (int.TryParse(Console.ReadLine(), out ch) && ch >= 1 && ch<= 7)
                {
                    try
                    {
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("\nEnter the Name of the item in the Shopping List.\n");
                                string i = Console.ReadLine();
                                Console.WriteLine("\nEnter the Priority of the item.\n");
                                int p = Convert.ToInt32(Console.ReadLine());
                                list2 = new Shoppinglist(i,p);
                                list1.Enqueue(list2);
                                Console.WriteLine("The item has been added to the Queue.\n");
                                break;
                            case 2:
                                list2 = list1.Dequeue();
                                Console.WriteLine("\nDequeue the item in the Shopping list:- \n{0}\t{1}",list2.priority, list2.item);
                                break;
                            case 3:
                                Console.WriteLine("\nThe Size of Queue is:- \n{0}",list1.Count());
                                break;
                            case 4:
                                Console.WriteLine("\nEnter the name of the item in the Shopping List.\n");
                                i = Console.ReadLine();
                                list1.Contains(i);
                                break;
                            case 5:
                                list1.Printlist();
                                break;
                            case 6:
                                Console.WriteLine("\nThe Highest Priority item in the Shopping list is :- \n" + list1.Peek().ToString());
                                break;
                            case 7:
                                break;
                            default:
                                Console.WriteLine("Wrong Choice!!");
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input!!");
                        throw;
                    }
                }
                else return;
            }
        }
    }
}
        
