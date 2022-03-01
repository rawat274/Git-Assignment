using System;

namespace CSharp8
{
    public class Program
    {

        public static void Main(string[] args)
        {
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
            Console.WriteLine("Enter the Number of elements in the list:- \n");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Priority of the elements in the list:- \n");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements in the list:- \n");
                b = int.Parse(Console.ReadLine());
                priorityQueue.Enqueue(a, b);
            }
            Console.WriteLine(priorityQueue.Peek());
            priorityQueue.Dequeue();
            Console.WriteLine(priorityQueue.Peek());
            Console.WriteLine(priorityQueue.Count());
            Console.WriteLine(priorityQueue.GetHighestPriority());
        }
    }
}