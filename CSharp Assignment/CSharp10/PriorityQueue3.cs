using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp10
{
    class PriorityQueue3<T> where T : IEquatable<T>
    {
        private class PriorityNode
        {
            public int Priority { get; private set; }
            public T data { get; private set; }
            public PriorityNode(int priority, T data)
            {
                this.Priority = priority;
                this.data = data;
            }
        }
        private IList<PriorityNode> elements;
        public PriorityQueue3()
        {
            elements = new List<PriorityNode>();
        }
        public int Count()
        {
            return elements.Count();
        }
        public bool Contains(T item)
        {
            foreach (PriorityNode node in elements)
            {
                if (node.data.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public T Dequeue()
        {
            T e = elements.First().data;
            elements.RemoveAt(0);
            return e;
        }
        public void Enqueue(int priority, T item)
        {
            if (elements.Count() == 0)
            {
                elements.Add(new PriorityNode(priority, item));
            }
            else
            {
                PriorityNode x = new PriorityNode(priority, item);
                foreach (PriorityNode n in elements)
                {
                    if (n.Priority > priority)
                    {
                        elements.Insert(elements.IndexOf(n), x);
                        break;
                    }
                }
                if (elements.Contains(x) == false)
                {
                    elements.Add(x);
                }
            }
        }
        public T Peek()
        {
            return elements.First().data;
        }
        public int GetHighestPriority()
        {
            return elements.First().Priority;
        }
    }
}
