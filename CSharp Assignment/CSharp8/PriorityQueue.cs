using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp8
{
    class PriorityQueue<T> where T : IEquatable<T>
    {
        private IDictionary<int, IList<T>> elements;
        public PriorityQueue()
        {
            elements = new SortedDictionary<int, IList<T>>();
        }
        public int Count()
        {
            return elements.Count();
        }
        public bool Contains(T item)
        {
            foreach (KeyValuePair<int, IList<T>> x in elements)
            {
                if (x.Value.Contains(item))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Queue is Empty.\n");
                }
            }
            return false;
        }
        public T Dequeue()
        {
            try
            {
                IList<T> list1 = elements[elements.Keys.First()];
                int p = elements.Keys.First();
                T e = list1.First();
                list1.Remove(e);
                if (list1.Count() == 0)
                {
                    elements.Remove(p);
                }
                return e;
            }
            catch (Exception)
            {
                Console.WriteLine("Queue is Empty.\n");
                throw;
            }
        }
        public void Enqueue(int p, T item)
        {
            IList<T> list2;
            if (!elements.ContainsKey(p))
                elements.Add(p, new List<T>());
            list2 = elements[p];
            list2.Add(item);
        }
        public T Peek()
        {
            IList<T> list1 = elements[elements.Keys.First()];
            T e = list1.First();
            return e;
        }
        public int GetHighestPriority()
        {
            return elements.Keys.First();
        }
    }
}
