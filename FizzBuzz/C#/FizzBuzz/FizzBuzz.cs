using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Run(int number)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException();

            if (number % 15 == 0)
                return "fizzbuzz";

            if (number % 5 == 0)
                return "buzz";

            if (number % 3 == 0)
                return "fizz";

            return number.ToString();
        }
    }
}
