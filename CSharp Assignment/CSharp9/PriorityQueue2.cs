using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp9 
{ 
    public class PriorityQueue2<T> where T : IComparable<T>, IPriority
    {
        private readonly List<T> list;
        public PriorityQueue2()
        {
            list = new List<T>();
        }
        public int Count() => list.Count;
        public bool Contains(string element)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Queue is empty.\n");
                return false;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsEquals(element))
                {
                    Console.WriteLine("The element present in the Queue:- \n" + list[i].ToString());
                    return true;
                }
            }
            Console.WriteLine("There no elemnets in the Queue.\n");
            return false;
        }
        public T Dequeue()
        {
            try
            {
                var lindex = list.Count - 1;
                var front = list[0];
                list[0] = list[lindex];
                list.RemoveAt(lindex);
                lindex--;
                var pindex = 0;
                while (true)
                {
                    var leftchild = pindex * 2 + 1;
                    if (leftchild > lindex) break;
                    var rc = leftchild + 1;
                    if (rc <= lindex && list[rc].CompareTo(list[leftchild]) < 0)
                        leftchild = rc;
                    if (list[pindex].CompareTo(list[leftchild]) <= 0)
                        break;
                    Swap(pindex, leftchild);
                    pindex = leftchild;
                }
                return front;
            }
            catch (Exception)
            {
                Console.WriteLine("Queue is empty.\n");
                throw;
            }
        }
        public void Enqueue(T item)
        {
            list.Add(item);
            var childindex = list.Count - 1;
            while (childindex > 0)
            {
                var pi = (childindex - 1) / 2;

                if (list[childindex].CompareTo(list[pi]) >= 0)
                    break;
                Swap(childindex, pi);
                childindex = pi;
            }
        }
        public T Peek() => list[0];
        public void Printlist()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Queue is empty.\n");
                return;
            }
            Console.WriteLine("The elements in the Queue are:- \n");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString() + '\n');

            }
        }
        private void Swap(int i1,int i2)         // for swap the values using index
        {
            var temp = list[i1];
            list[i1] = list[i2];
            list[i2] = temp;
        }
    }
    public class Shoppinglist : IComparable<Shoppinglist>, IPriority
    {
        public string item;
        public double priority;
        public Shoppinglist(string item, double priority)
        {
            this.item = item;
            this.priority = priority;
        }
        public override string ToString()
        {
            return Convert.ToString(priority) + ' ' + item;
        }
        public int CompareTo(Shoppinglist l)
        {
            if (priority < l.priority) return -1;
            if (priority > l.priority) return 1;
            return 0;
        }
        public bool IsEquals(string l)
        {
            return item == l;
        }
    }
}