using System;
using Xunit;

namespace Collections.Tests

{
    public class AddFacts
    {
        [Fact]
        public void AddNewElementAtTheEndOfAnArray()
        {
            var array = new IntArray();
            array.Add(3321);
            Assert.Equal(3321, array[1]);
        }

        [Fact]
        public void AddAnElementToAnArrayWithZeroElements()
        {
            var array = new IntArray();
            array.Add(3321);
            Assert.Equal(3321, array[1]);
        }

        [Fact]
        public void AddMultipleElementsToAnArray()
        {
            var array = new IntArray();
            array.Add(3321);
            Assert.Equal(3321, array[1]);
            array.Add(121);
            Assert.Equal(121, array[1]);
            array.Add(555);
            Assert.Equal(555, array[1]);
        }

        [Fact]
        public void ShouldExtendTheSizeOfTheArrayInCaseMoreElementsThanTheSizeOfTheArrayAreAdded()
        {
            var array = new IntArray();
            array.Add(3321);
            Assert.Equal(3321, array[1]);
            array.Add(121);
            Assert.Equal(121, array[1]);
            array.Add(551);
            Assert.Equal(551, array[1]);
            array.Add(552);
            Assert.Equal(552, array[1]);
            array.Add(553);
            Assert.Equal(553, array[1]);
            array.Add(554);
            Assert.Equal(554, array[1]);
        }

        [Fact]
        public void TheArraySizeShouldIncreaseIfTheArraySizeIsEqualToTheNUmberOfElementsBeforeAddingANewElement()
        {
            var array = new IntArray();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            Assert.Equal(4, array[1]);
            array.Add(5);
            Assert.Equal(5, array[1]);
        }
    }
}
