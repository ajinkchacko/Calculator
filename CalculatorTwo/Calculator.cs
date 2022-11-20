namespace CalculatorTwo
{
    public static class Calculator
    {
        /// <summary>
        /// Calculate the compound increase of a value 
        /// for a given interest rate for a given period of time in years
        /// </summary>
        public static double CompoundIncrease(double value, double interestRate, int years)
        {
            if (value < 0 || interestRate < 0 || years < 0)
            {
                throw new ArgumentException("Invalid Value, Interest or Year");
            }

            for (int i = 0; i < years; i++)
            {
                value += (value * interestRate)/100;
            } 

            return value;
        }

        /// <summary>
        /// Calculate the compound decrease of a value 
        /// for a given interest rate for a given period of time in years
        /// </summary>
        public static double CompoundDecrease(double value, double interestRate, int years)
        {
            if (value < 0 || interestRate < 0 || years < 0)
            {
                throw new ArgumentException("Invalid Value, Interest or Year");
            }

            for (int i = 0; i < years; i++)
            {
                value -= (value * interestRate) / 100;
            }

            return value;
        }

    }
}