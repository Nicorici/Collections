using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class LinkedList<T> : ICollection<T>
    {
        private Node<T> sentinel = new Node<T>();

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public LinkedList()
        {
            sentinel.Next = sentinel;
            sentinel.Previous = sentinel;
        }

        public Node<T> FindFirst(T value)
        {
            var indexer = sentinel.Next;
            return Find(indexer, value);
        }

        public Node<T> FindLast(T value)
        {
            var indexer = sentinel.Previous;
            return Find(indexer, value);
        }

        public bool Contains(T value)
        {
            return !(FindFirst(value).Equals(null));
        }

        public Node<T> AddAfter(Node<T> node, T value)
        {
            var newNode = new Node<T>() { Value = value };
            var inserAfter = FindFirst(node.Value);

            newNode.Next = inserAfter.Next;
            newNode.Previous = inserAfter;
            inserAfter.Next.Previous = newNode;
            inserAfter.Next = newNode;
            Count++;
            return newNode;
        }

        public Node<T> AddFirst(T value)
        {
           return AddAfter(sentinel, value);
        }

        public Node<T> AddLast(T value)
        {
           return AddAfter(sentinel.Previous, value);
        }

        public Node<T> AddBefore(Node<T> node, T value)
        {
            var insertBefore = Find(sentinel.Next, node.Value);
           return AddAfter(insertBefore.Previous, value);
        }

        public void Remove(Node<T> node)
        {
            var toRemove = Find(sentinel.Next, node.Value);
            toRemove.Previous.Next = toRemove.Next;
            toRemove.Next.Previous = toRemove.Previous;
            Count--;
        }

        public void RemoveFirst()
        {
            Remove(sentinel.Next);
        }

        public void RemoveLast()
        {
            Remove(sentinel.Previous);
        }

        public void Clear()
        {
            sentinel.Next = sentinel;
            sentinel.Previous = sentinel;
        }


        private Node<T> Find(Node<T> current, T value)
        {
            bool clockwise = current.Equals(sentinel.Next);

            if (value.Equals(sentinel.Value))
                return sentinel;

            while (!current.Equals(sentinel))
            {
                if (current.Value.Equals(value))
                {
                        return current;
                }
                current = clockwise ? current.Next : current.Previous;
            }
            return null;
        }

        public string Print()
        {
            string result = "";
            var indexer = sentinel.Next;
            while (!(indexer.Equals(sentinel)))
            {
                Console.WriteLine(indexer.Value);
                result += indexer.Value.ToString() + " ";
                indexer = indexer.Next;
            }
            return result.TrimEnd();
        }

        public void Add(T value)
        {
            AddFirst(value);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var current = sentinel.Next;
            for (int i = arrayIndex; !current.Equals(sentinel); i++, current = current.Next)
                array[i] = current.Value;
        }

        public bool Remove(T value)
        {
            Remove(FindFirst(value));
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var indexer = sentinel.Next;
            while (!(indexer.Equals(sentinel)))
            {
                yield return indexer.Value;
                indexer = indexer.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
