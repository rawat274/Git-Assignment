using System;

namespace CSharp10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PriorityQueue3<int> priorityQueue3 = new PriorityQueue3<int>();
            Console.WriteLine("Enter the Number of elements in the list:- \n");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Priority of the elements in the list:- \n");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements in the list:- \n");
                b = int.Parse(Console.ReadLine());
                priorityQueue3.Enqueue(a, b);
            }
            Console.WriteLine(priorityQueue3.Peek());
            priorityQueue3.Dequeue();
            Console.WriteLine(priorityQueue3.Peek());
            Console.WriteLine(priorityQueue3.Count());
            Console.WriteLine(priorityQueue3.GetHighestPriority());
        }
    }
}