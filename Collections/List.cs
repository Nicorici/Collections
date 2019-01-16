using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class List<T> : IList<T>
    {
        private T[] initialArray = new T[4];
        public int Count
        { get; set; }

        public T[] Array => initialArray;

        public bool IsReadOnly => false;

        public T this[int index]
        {
            get => initialArray[index];
            set => initialArray[index] = value;
        }

        public IEnumerator<T>  GetEnumerator()
        {
            var sum = 0;
            for (int i = 0; i < Count; i++)
            {
                yield return initialArray[i];
                sum += i;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public virtual void Add(T element)
        {
            EnsureCapacity();
            initialArray[Count] = element;
            Count++;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < Count; i++)
                if (initialArray[i].Equals(element))
                    return i;
            return -1;
        }

        public bool Contains(T element)
        {
            return (IndexOf(element) != -1);
        }

        public virtual void Insert(int index, T element)
        {
            EnsureCapacity();
            for (int i = initialArray.Length - 1; i > index; i--)
            {
                Swap(i, i - 1);
            }
            initialArray[index] = element;
            Count++;
        }

        public void Clear()
        {
            Count = 0;
        }

        public bool Remove(T element)
        {
            int index = IndexOf(element);
            if (index == -1)
                return false;
                RemoveAt(index);
            return true;
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
            T temp = initialArray[second];
            initialArray[second] = initialArray[first];
            initialArray[first] = temp;
        }

        internal void EnsureCapacity()
        {
            if (Count == initialArray.Length)
            {
                System.Array.Resize(ref initialArray, initialArray.Length * 2);
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("Array cannot be null");
            if (arrayIndex < 0|| arrayIndex>=array.Length)
                throw new IndexOutOfRangeException("Index cannot be smaller than the first elemnt of the array");
            if (arrayIndex + Count > array.Length)
                throw new ArgumentException("The number of elements needed to be copied is greater than " +
                                            " the availbale space from index to the end of the array");

            for (int i = 0; i < Count; i++, arrayIndex++)
                array[arrayIndex] = initialArray[i];
        }
    }
}

