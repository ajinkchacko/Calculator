using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorTwo;

namespace CalculatorApp.ViewModel
{
    public class CalculatorTwoVM
    {
        /// <summary>
        /// Find the compound increase of a value 
        /// </summary>
        public string FindCompoundIncrease(string value, string interestRate, string years)
        {
            string result;
            try
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(interestRate) || string.IsNullOrEmpty(years))
                {
                    throw new ArgumentException("Invalid Value, Interest or Year");
                }

                var compoundIncrease = Calculator.CompoundIncrease(Double.Parse(value), Double.Parse(interestRate), int.Parse(years));

                result = "Compound Increase = " + compoundIncrease.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Find the compound decrease of a value 
        /// </summary>
        public string FindCompoundDecrease(string value, string interestRate, string years)
        {
            string result;
            try
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(interestRate) || string.IsNullOrEmpty(years))
                {
                    throw new ArgumentException("Invalid Value, Interest or Year");
                }

                var compoundDecrease = Calculator.CompoundDecrease(Double.Parse(value), Double.Parse(interestRate), int.Parse(years));

                result = "Compound Decrease = " + compoundDecrease.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

    }
}
