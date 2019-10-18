using System;
namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;

            if (!double.TryParse(argTextInput, out convertedNumber))
            {
                throw new ArgumentException("Numeric value not inserted.");
            }

            return convertedNumber;
        }
    }
}