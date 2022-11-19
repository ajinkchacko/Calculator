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

        private List<double> ConvertStringToDoubleList(string stringNumbers)
        {
            if(stringNumbers == null || stringNumbers.Length == 0)
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

        public string FindArithmeticMean(string numbers)
        {
            string meanResult;
            try
            {
                var numbersList = ConvertStringToDoubleList(numbers);
                var arithmeticMean = Calculator.ArithmeticMean(numbersList);

                meanResult = "Arithmetic Mean = " + arithmeticMean.ToString();
            }
            catch (Exception ex)
            {
                meanResult = ex.Message;
            }
            return meanResult;
        }
    }
}
