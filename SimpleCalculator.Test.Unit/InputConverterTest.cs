using System;
using Xunit;

namespace SimpleCalculator.Test.Unit
{
    public class InputConverterTest
    {
        private readonly InputConverter inputConverter = new InputConverter();

        [Fact]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";

            double convertedNumber = inputConverter.ConvertInputToNumeric(inputNumber);

            Assert.Equal(5, convertedNumber);
        }

        [Fact]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";

            Exception ex = Assert.Throws<ArgumentException>(() => inputConverter.ConvertInputToNumeric(inputNumber));

            Assert.Equal("Numeric value not inserted.", ex.Message);
        }
    }
}
