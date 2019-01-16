using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Enumerator : IEnumerator
    {
        private readonly object [] array;
        private int position = -1;
        private readonly int count;

        public Enumerator( object [] array,int count)
        {
            this.array = array;
            this.count = count;
        }

        public bool MoveNext()
        {
            position++;
            return (position < count);
        }

        public object Current
        {
            get
            {  
                return array[position];
            }
        }

        public void Reset()
        {
            position = -1;
        }


    }
}
