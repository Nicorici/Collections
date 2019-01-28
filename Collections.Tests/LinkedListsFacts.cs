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
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(6);
            var node = linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddAfter(node, 88);

            Assert.Equal("1 2 3 4 5 88 6", linkedList.Print());
        }

        [Fact]
        public void ClearAListOfElemnts()
        {
            var linkedList = new LinkedList<int>() { 9, 9, 8, 8, 7, 7, 7, 6, 5, 4, 3, 2, 2, 2, 1, 1, 1 };
            linkedList.Clear();
            Assert.Equal("", linkedList.Print());
        }

        [Fact]
        public void RemoveFirstElementOfAList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.RemoveFirst();
            Assert.Equal("2 3", linkedList.Print());
        }

        [Fact]
        public void RemoveLastElementOfAList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.RemoveLast();
            Assert.Equal("1 2", linkedList.Print());
        }

        [Fact]
        public void RemoveAnElementFromTheList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(3);
            var remove = linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.Remove(remove);
            Assert.Equal("1 3", linkedList.Print());
        }

        [Fact]
        public void TryAddingANodeAfterAnElementWhichIsNull()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            Node<int> node = null;
            Assert.Throws<ArgumentNullException>(() => linkedList.AddAfter(node, 4));
        }

        [Fact]
        public void TryAddingANodeAfterAnElementWhichIsNotInCurrentCollection()
        {
            var firstList = new LinkedList<int>();
            firstList.AddFirst(21);
            var node = firstList.AddFirst(20);

            var secondList = new LinkedList<int>();
            secondList.AddFirst(2);
            Assert.Throws<InvalidOperationException>(() => secondList.AddAfter(node, 3));
        }

        [Fact]
        public void TryAddingANodeBeforeAnElementWhichIsNull()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            Node<int> node = null;
            Assert.Throws<ArgumentNullException>(() => linkedList.AddBefore(node, 4));
        }

        [Fact]
        public void TryAddingANodeBefoerAnElementWhichIsNotInCurrentCollection()
        {
            var firstList = new LinkedList<int>();
            firstList.AddFirst(21);
            var node = firstList.AddFirst(20);

            var secondList = new LinkedList<int>();
            secondList.AddFirst(2);
            Assert.Throws<InvalidOperationException>(() => secondList.AddBefore(node, 3));
        }

        [Fact]
        public void AddAlinkedListInANullArray()
        {
            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            int[] array = null;
            Assert.Throws<ArgumentNullException>(() => list.CopyTo(array, 1));
        }

        [Fact]
        public void AddAlinkedListInAnArrayWhereTheStartIndexIsANegativeNumber()
        {
            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            int[] array = new int[20];
            Assert.Throws<IndexOutOfRangeException>(() => list.CopyTo(array, -3));
        }

        [Fact]
        public void AddAlinkedListInAnArrayWhereTheStartIndexIsGreaterThanTheLengthOfTheArray()
        {
            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            int[] array = new int[2];
            Assert.Throws<ArgumentException>(() => list.CopyTo(array, 0));
        }

        [Fact]
        public void RemoveANullNodeFromALinkedList()
        {
            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            Node<int> node = null;
            Assert.Throws<ArgumentNullException>(() => list.Remove(node));
        }

        [Fact]
        public void TryRemovingANodeFromACollectionDifferentThanTheCurrentOne()
        {
            var list = new LinkedList<int>();
            list.AddFirst(21);
            var node = list.AddFirst(20);

            var currentList = new LinkedList<int>();
            currentList.AddFirst(2);
            Assert.Throws<InvalidOperationException>(() => currentList.Remove(node));
        }

        [Fact]
        public void TryRemovingTheFirstNodeOfAnEmptyList()
        {
            var list = new LinkedList<int>();
            Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
        }

        [Fact]
        public void TryRemovingTheLastNodeOfAnEmptyList()
        {
            var list = new LinkedList<int>();
            Assert.Throws<InvalidOperationException>(() => list.RemoveLast());
        }

    }
}
