namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {
        [Fact]
        public void FizzBuzzifyAnInt_TestCases()
        {
            //Create test class
            var fizzBuzzClass = new FizzBuzz();
            //Test neither multiple of 3 nor 5
            Assert.Equal("13", fizzBuzzClass.FizzBuzzifyAnInt(13));
            //Test multiple of 3
            Assert.Equal("Fizz", fizzBuzzClass.FizzBuzzifyAnInt(6));
            //Test multiple of 5
            Assert.Equal("Buzz", fizzBuzzClass.FizzBuzzifyAnInt(10));
            //Test multiple of 15
            Assert.Equal("FizzBuzz", fizzBuzzClass.FizzBuzzifyAnInt(30));
        }
    }
}
