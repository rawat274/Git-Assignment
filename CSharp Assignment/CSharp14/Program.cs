using System;
using System.Collections.Generic;

namespace CSharp14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<Product, int> productlist = new Dictionary<Product, int>();
            int ch = -1;
            while (ch != 5)
            {
                Console.WriteLine("1. Add Product.");
                Console.WriteLine("2. Remove Product.");
                Console.WriteLine("3. Update Product Quantity.");
                Console.WriteLine("4. Display the Total Value of the Inventory.");
                Console.WriteLine("5. Exit.");
                Console.WriteLine("Enter your Choice :- \n ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:  // Add Product
                        int id = (new Random()).Next(1000, 100000);
                        Console.WriteLine("The Product ID is:- {0}\n", id);
                        Console.WriteLine("Enter the Product Price:- \n");
                        float price = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Product quantities:- \n ");
                        int q = int.Parse(Console.ReadLine());
                        Console.WriteLine("Is the Product defective? yes/no:- \n");
                        string s = Console.ReadLine();
                        bool isDefective = false;
                        if (s.ToLower().CompareTo("yes") == 0)
                        {
                            isDefective = true;
                        }
                        Product p = new Product(id, price, isDefective);
                        if (!p.IsDefective)
                        {
                            productlist.Add(p, q);
                            Console.WriteLine("\nA new product has been added.\n");
                        }
                        break;
                    case 2:  // Remove Product
                        Console.WriteLine("Enter the product ID to remove:- \n ");
                        id = int.Parse(Console.ReadLine());
                        Product sp = null;
                        foreach (var product in productlist)
                        {
                            if (product.Key.Id == id)
                            {
                                sp = product.Key;
                                break;
                            }
                        }
                        if (sp != null)
                        {
                            productlist.Remove(sp);
                            Console.WriteLine("\nThe productroduct has been removed.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nThe Product does not exist.\n");
                        }
                        break;
                    case 3:  //Update Product Quantity
                        Console.WriteLine("Enter the Product ID to update product quantity:-\n ");
                        id = int.Parse(Console.ReadLine());
                        sp = null;
                        foreach (var product in productlist)
                        {
                            if (product.Key.Id == id)
                            {
                                sp = product.Key;
                                break;
                            }
                        }
                        if (sp != null)
                        {
                            Console.WriteLine("Enter a new product quantities:- \n ");
                            q = int.Parse(Console.ReadLine());
                            productlist[sp] = q;
                            Console.WriteLine("\nThe product quantity has been updated.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nThe product does not exist.\n");
                        }
                        break;
                    case 4: //Display the Total Value of the Inventory
                        float total = 0;
                        foreach (var product in productlist)
                        {
                            total += product.Key.Price * product.Value;
                        }
                        Console.WriteLine("The Total Value of the Inventory is:- \n {0}", total.ToString("N2"));
                        break;
                    case 5: //exit
                        break;
                    default: //default
                        Console.WriteLine("Wrong Choice!!");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}