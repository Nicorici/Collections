using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class IntArray
    {
        private int[] initialArray = new int[4];
        public int Count
        { get; set; }

        public int[] Array => initialArray;

        public int this[int index]
        {
            get => Array[index];
            set => Array[index] = value;
        }

        public virtual void Add(int element)
        {
            EnsureCapacity();
            Array[Count] = element;
            Count++;
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < Count; i++)
                if (Array[i] == element)
                    return i;
            return -1;
        }

        public bool Contains(int element)
        {
           return IndexOf(element) != -1 ;
        }

        public virtual void InsertElement(int index, int element)
        {
            EnsureCapacity();
            for (int i = Array.Length - 1; i > index; i--)
            {
                Swap(i, i - 1);
            }
            Array[index] = element;
            Count++;
        }

        public void Clear()
        {
            Count = 0;
        }

        public void Remove(int element)
        {
            int index = IndexOf(element);
            if (index != -1)
                RemoveAt(index);
        }

        public void RemoveAt(int index)
        {
            while (index < Count)
            {
                Swap(index, index + 1);
                index++;
            }
            Count--;
        }

        public void Swap(int first, int second)
        {
            int temp = Array[second];
            Array[second] = Array[first];
            Array[first] = temp;
        }

        internal void EnsureCapacity()
        {
            if (Count == Array.Length)
            {
                System.Array.Resize(ref initialArray, Array.Length * 2);
            }
        }
    }
}
