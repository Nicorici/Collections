using System;
using Xunit;
namespace Collections.Tests
{
    public class CountFacts
    {
        [Fact]
        public void ShouldReturnZeroInCaseNoElementIsAdded()
        {
            var array = new IntArray();
            Assert.Equal(0, array.Count);
        }

        [Fact]
        public void ShouldReturnTheNumberOfElementsAddedInTheArrayAndNotTheArraySize()
        {
            var array = new IntArray();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            Assert.Equal(3, array.Count);
        }
    }
}
