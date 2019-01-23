using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class App
    {
        static void Main()
        {
              var linked = new System.Collections.Generic.LinkedList<int>();
            var node = new LinkedListNode<int>(1);
            linked.AddFirst(node);
            var x = linked.AddAfter(node, 5);

            var list = new LinkedList<int>() {1,2,3,4 };
            list.Print();
            list.Print();
            list.FindFirst(4);
            Console.Read();


        }

    }
}
