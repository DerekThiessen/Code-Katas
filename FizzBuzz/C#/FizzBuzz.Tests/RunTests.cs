using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class RunTests
    {
        private FizzBuzz _fixxBuzz;

        public RunTests()
        {
            _fixxBuzz = new FizzBuzz();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void when_number_is_less_than_or_equal_to_zero_Throws_ArgumentOutOfRangeException(int number)
        {
            var fizzBuzz = new FizzBuzz();

            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => fizzBuzz.Run(number));

            Assert.Equal("Specified argument was out of the range of valid values.", ex.Message);
        }

        [Fact]
        public void when_number_is_one()
        {
            var result = _fixxBuzz.Run(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void when_number_is_divisible_by_three_then_fizz()
        {
            var result = _fixxBuzz.Run(3);
            
            Assert.Equal("fizz", result);
        }

        [Fact]
        public void when_number_is_divisible_by_five_then_buzz()
        {
            var result = _fixxBuzz.Run(10);

            Assert.Equal("buzz", result);
        }

        [Fact]
        public void when_number_is_divisible_by_3_and_5_then_fizzbuzz()
        {
            var result = _fixxBuzz.Run(15);

            Assert.Equal("fizzbuzz", result);
        }
    }
}
