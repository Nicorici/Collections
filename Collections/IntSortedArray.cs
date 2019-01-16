using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class IntSortedArray : IntArray
    {
        public int[] Sorted
        {
            get
            {
                return Array;
            }
        }

        public override void InsertElement(int index, int element)
        {
            throw new Exception("Invalid method for class,use the Add method instead");
        }

        public override void Add(int element)
        {
            if (Array[0] >= element)
            {
                InsertElement(0, element);
                return;
            }
            for (int i = 0; i < Count; i++)
            {
                if (Array[i] <= element)
                    if (i + 1 == Count || Array[i + 1] >= element)
                    {
                        InsertElement(i + 1, element);
                        break;
                    }
            }
        }
    }
}
