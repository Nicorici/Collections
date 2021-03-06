﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Node<T>
    {
        public LinkedList<T> List { get; set; }
        public Node<T> Next { get;  set; }
        public Node<T> Previous { get;set; }
        public T Value { get; set;}
    }
}
