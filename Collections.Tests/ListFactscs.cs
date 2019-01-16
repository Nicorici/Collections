using System;
using Xunit;

namespace Collections.Tests
{
    public class ListFactscs
    {
        [Fact]
        public void CopyASmallArrayInALargerArray()
        {
            var list = new List<string> { "cat", "dog", "horse", "cow" };
            string[] array = new string[6];
            list.CopyTo(array, 1);
            Assert.Equal("cat", array[1]);
            Assert.Equal("dog", array[2]);
            Assert.Equal("horse", array[3]);
            Assert.Equal("cow", array[4]);
            Assert.Null( array[5]);
        }

        [Fact]
        public void TheLengthOfTheArrayNeddedToBeCopiedIsGreaterThanTheLengthOfTheHostArray()
        {
            var list = new List<string> { "cat", "dog", "horse", "cow" };
            string[] array = new string[3];
        } 
    }
}
