using System;
using Xunit;
namespace Collections.Tests
{
    public class SetElementFacts
    {
        [Fact]
        public void ShouldReplaceTheElementAtThendegWithTheNewGivenElement()
        {
            var array = new IntArray();
            array.Add(1);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            Assert.Equal(445, array[1]);
        }
    }
}
