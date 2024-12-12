namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using FluentAssertions.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class FizzBuzzReplacePairTests
    {
        [Fact]
        public void FizzBuzzReplacePairs_TestCases()
        {
            //Replacement pair for detecting even integers
            Dictionary<int, string> ReplacePairEven = new Dictionary<int, string>
            {
                { 2, "Even" },
            };
            //Replacement pairs for detecting quack/honk
            Dictionary<int, string> ReplacePairQuackHonk = new Dictionary<int, string>
            {
                { 2, "Quack" },
                { 5, "Honk" },
            };
            //Expected result for normal 1-10 FizzBuzz
            List<string> expectedResultNormal = new List<string> {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz"
            };
            //Expected result for even integer 1-10 FizzBuzz
            List<string> expectedResultEven = new List<string> {
                "1",
                "Even",
                "3",
                "Even",
                "5",
                "Even",
                "7",
                "Even",
                "9",
                "Even",
            };
            //Expected result for quack/honk 1-10 FizzBuzz
            List<string> expectedResultQuackHonk = new List<string> {
                "1",
                "Quack",
                "3",
                "Quack",
                "Honk",
                "Quack",
                "7",
                "Quack",
                "9",
                "QuackHonk",
            };
            //Create test class
            var fizzBuzzClass = new FizzBuzz();
            //Test normal FizzBuzz result
            var result = fizzBuzzClass.FizzBuzzValuesForRange(1, 10).ToList<string>();
            Assert.True(result.SequenceEqual(expectedResultNormal));
            //Test even integer replacement pairs
            fizzBuzzClass.SetReplacementPairs(ReplacePairEven);
            result = fizzBuzzClass.FizzBuzzValuesForRange(1, 10).ToList<string>();
            Assert.True(result.SequenceEqual(expectedResultEven));
            //Test quack/honk replacement pairs
            fizzBuzzClass.SetReplacementPairs(ReplacePairQuackHonk);
            result = fizzBuzzClass.FizzBuzzValuesForRange(1, 10).ToList<string>();
            Assert.True(result.SequenceEqual(expectedResultQuackHonk));
        }
    }
}
