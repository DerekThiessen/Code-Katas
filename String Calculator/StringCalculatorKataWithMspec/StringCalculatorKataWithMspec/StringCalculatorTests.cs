using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace StringCalculatorKataWithMspec
{
    class when_empty_string
    {
        static StringCalculator stringCalculator;
        static int returnValue;

        Establish context = () => stringCalculator = new StringCalculator();

        Because of =()=> returnValue = stringCalculator.Add("");

        It should_return_zero = () => returnValue.ShouldEqual(0);
    }
}
