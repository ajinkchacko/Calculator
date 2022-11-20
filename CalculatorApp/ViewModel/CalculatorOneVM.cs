using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorOne;

namespace CalculatorApp.ViewModel
{
    public class CalculatorOneVM
    {
        /// <summary>
        /// Find the arithmetic mean of a list of numbers input
        /// </summary>
        public string FindArithmeticMean(string numbers)
        {
            string result;
            try
            {
                var numbersList = ConvertStringToDoubleList(numbers);
                var arithmeticMean = Calculator.ArithmeticMean(numbersList);

                result = "Arithmetic Mean = " + arithmeticMean.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Find the standard deviation for a list of numbers
        /// </summary>
        public string FindStandardDeviation(string numbers)
        {
            string result;
            try
            {
                var numbersList = ConvertStringToDoubleList(numbers);
                var standardDeviation = Calculator.StandardDeviation(numbersList);

                result = "Standard Deviation = " + standardDeviation.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Find the frequencies of numbers in bins of 10
        /// </summary>
        public string FindtheFrequenciesOfNumbers(string numbers, ref Dictionary<string, int> frequencies)
        {
            string result;
            try
            {
                var numbersList = ConvertStringToDoubleList(numbers);
                frequencies = Calculator.FrequenciesOfNumbers(numbersList, 10);

                result = "Frequencies of numbers";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Find the square root of a number
        /// </summary>
        public string FindSquareRoot(string number)
        {
            string result;
            try
            {
                var numberToCalc = ConvertStringToDouble(number);
                var squareRoot = Calculator.SquareRoot(numberToCalc);

                result = "Square Root = " + squareRoot.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Convert string to list of double
        /// </summary>
        private List<double> ConvertStringToDoubleList(string stringNumbers)
        {
            if (stringNumbers == null || stringNumbers.Length == 0)
            {
                throw new ArgumentException("There should be atleast one number to calculate");
            }

            var numberList = stringNumbers.Split(',').ToList();
            numberList = numberList.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            if (numberList.Count == 0)
            {
                throw new ArgumentException("There should be atleast one number to calculate");
            }

            return numberList.Select(Double.Parse).ToList();
        }

        /// <summary>
        /// Convert string to double
        /// </summary>
        private double ConvertStringToDouble(string stringNumber)
        {
            if (String.IsNullOrEmpty(stringNumber))
            {
                throw new ArgumentException("There should be atleast one number to calculate");
            }

            return Double.Parse(stringNumber);
        }
    }
}
