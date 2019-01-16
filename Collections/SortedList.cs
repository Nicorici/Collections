using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class SortedList<T> : List<T> where T : IComparable<T>
    {
        public override void Insert(int index, T element)
        {
            //if (index == 0 && Array[0].CompareTo(element) == 1 ||
            //    index == Count  && Array[1].CompareTo(element) == -1 ||
            //    Array[index - 1].CompareTo(element) <= 0 && Array[index + 1].CompareTo(element) >= 0)

            EnsureCapacity();
            for (int i = Count; i > index; i--)
            {
                Swap(i, i - 1);
            }
            Array[index] = element;
            Count++; 
            
           
        }

        public override void Add(T element)
        {
            if (Count==0 || Array[0].CompareTo(element) >= 0 )
            {
                Insert(0, element);
                return;
            }

            for (int i = 0; i < Count; i++)
            {
                if (Array[i].CompareTo(element) >= 0)
                {
                    Insert(i, element);
                    return;
                }
            }
            Insert(Count, element);
        }
    }
}
