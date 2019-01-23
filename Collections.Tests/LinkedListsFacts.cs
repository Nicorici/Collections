using System;
using Xunit;
namespace Collections.Tests
{
    public class LinkedListsFacts
    {
        [Fact]
        public void AddAnElementAtTheBeginningEmptyLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(2);
            Assert.Equal("2", linkedList.Print());
        }

        [Fact]
        public void AddMultipleElementsAtTheBeginningOfAnEmptyLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);
            linkedList.AddFirst(5);
            linkedList.AddFirst(6);

            Assert.Equal("6 5 4 3 2 1", linkedList.Print());
        }

        [Fact]
        public void AddMultipleElementsAtTheEndOfAnEmptyLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(6);

            Assert.Equal("1 2 3 4 5 6", linkedList.Print());
        }

        [Fact]
        public void AddElementAfterTheElementWithTheValue5()
        {
            var linkedList = new LinkedList<int>() { 6, 5, 4, 3, 2, 1 };
            var node = new Node<int>() { Value = 5 };
            linkedList.AddAfter(node,88);
            Assert.Equal("1 2 3 4 5 88 6", linkedList.Print());
        }

        [Fact]
        public void ClearAListOfElemnts()
        {
            var linkedList = new LinkedList<int>() { 9, 9, 8, 8, 7, 7, 7, 6, 5, 4, 3, 2, 2, 2, 1, 1, 1 };
            linkedList.Clear();
            Assert.Equal("", linkedList.Print());
        }

       


    }
}
