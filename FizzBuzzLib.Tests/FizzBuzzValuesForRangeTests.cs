namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using System;
    using System.Linq;
    using Xunit;

    public class FizzBuzzValuesForRangeTests
    {
        [Fact]
        public void FizzBuzzValuesForRange_TestCases()
        {
            //Create test class
            var fizzBuzzClass = new FizzBuzz();
            //Test first input negative exception
            Assert.Throws<System.NotImplementedException>(() => fizzBuzzClass.FizzBuzzValuesForRange(0, -1));
            //Test second input negative exception
            Assert.Throws<System.NotImplementedException>(() => fizzBuzzClass.FizzBuzzValuesForRange(-1, 0));
            //Test end before start exception
            Assert.Throws<System.NotImplementedException>(() => fizzBuzzClass.FizzBuzzValuesForRange(7, 3));
            //Generate FizzBuzz output
            var rangeResult = fizzBuzzClass.FizzBuzzValuesForRange(10, 16);
            //Check if length of output is correct
            Assert.Equal(7, rangeResult.Count());
            //Check if certain values in result are correct
            Assert.Equal("Buzz", rangeResult.First()); //First element (10)
            Assert.Equal("Fizz", rangeResult.ElementAt(2)); //Third element (12)
            Assert.Equal("13", rangeResult.ElementAt(3)); //Fourth element (13)
            Assert.Equal("FizzBuzz", rangeResult.ElementAt(5)); //Sixth element (15)
            Assert.Equal("16", rangeResult.Last()); //Last element (16)
        }
    }
}
