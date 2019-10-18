using System;
using Xunit;

namespace SimpleCalculator.Test.Unit
{
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine calculatorEngine = new CalculatorEngine();

        [Fact]
        public void AddTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;

            double result = calculatorEngine.Calculate("add", number1, number2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void AddTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;

            double result = calculatorEngine.Calculate("+", number1, number2);

            Assert.Equal(3, result);
        }
    }
}
