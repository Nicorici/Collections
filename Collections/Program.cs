using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class App
    {
        static void Main()
        {
            var sss = new SortedList<int>
            {
                1,
                5,
                4,
                2
            };
            for (int i=0;i<sss.Array.Length;i++)
                Console.WriteLine(sss.Array[i]);
            Console.Read();
        }

    }
}
