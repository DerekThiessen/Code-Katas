using Machine.Specifications;

namespace FizzBuzz
{
	class FizzBuzzTests
	{
		private static FizzBuzz fizzBuzz;

		private Establish context = () => fizzBuzz = new FizzBuzz();

		private Because of = () => { };

		private It should_return_zero = () => { };
	}
}
