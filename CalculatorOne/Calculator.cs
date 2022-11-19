using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOne
{
    public static class Calculator
    {

        private static void ValidateNumbers(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("Numbers not find");
            }

            if (numbers.Any(x => x < 0 || x > 100))
            {
                throw new ArgumentException("Numbers should be between 0 and 100 inclusive");
            }

            if (!numbers.Any(x => x != 0))
            {
                throw new ArgumentException("Atleast one number shuold be greater than 0");
            }
        }

        public static double ArithmeticMean(List<double> numbers)
        {
            ValidateNumbers(numbers);

            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Count;
        }

        public static double StandardDeviation(List<double> numbers)
        {
            ValidateNumbers(numbers);

            double mean = ArithmeticMean((List<double>)numbers);

            double sumSquaredDeviations = 0;
            foreach (var num in numbers)
            {
                sumSquaredDeviations += ((num - mean) * (num - mean));
            }

            double variance = sumSquaredDeviations / numbers.Count;

            return SquareRoot(variance);
        }

        public static Dictionary<string, int> FrequenciesOfNumbers(List<double> numbers, int binSize)
        {
            ValidateNumbers(numbers);

            var frequencies = new Dictionary<string, int>();

            for (int binStart = 0; binStart <= 100; binStart += binSize)
            {
                int binEnd = binStart + binSize;
                string key = binStart + " - " + binEnd;
                int value = numbers.Where(x => x >= binStart && x < binEnd).Count();
                if (value > 0)
                {
                    frequencies.Add(key, value);
                }
            }

            return frequencies;
        }

        public static double SquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Number should not be less than 0");
            }

            double root = 1;
            int i = 0;

            while (true)
            {
                i++;
                root = (number / root + root) / 2;
                if (i == number + 1) { break; }
            }

            return root;
        }


    }
}
