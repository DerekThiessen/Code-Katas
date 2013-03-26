using NUnit.Framework;

namespace FizzBuzz
{
	[TestFixture]
	public class FizzBuzzTest
	{
		[TestCase(1,1)]
		[TestCase(2,2)]
		[TestCase(3,"fixx")]
		public void Go(int input, string result)
		{
			var fizzBuzz = new FizzBuzz();
			
		}
	}
}
