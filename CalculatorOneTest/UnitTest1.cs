using System;
using CalculatorOne;

namespace CalculatorOneTest
{
    public class Tests
    {
        private List<double> numbers;

        [SetUp]
        public void Setup()
        {
            numbers = new List<double>();
        }

        [Test]
        public void ValidateNumbers_Valid_Numbers()
        {
            numbers.Add(0.5);
            numbers.Add(1);
            numbers.Add(6.3);
            numbers.Add(87.9);

            var validate = Calculator.ValidateNumbers(numbers);

            Assert.That(validate, Is.True);
        }

        [Test]
        public void ValidateNumbers_Empty()
        {
            Assert.Throws<ArgumentException>(() => Calculator.ValidateNumbers(numbers));
        }

        [Test]
        public void ValidateNumbers_LessThanZero()
        {
            numbers.Add(-10);
            numbers.Add(50);

            Assert.Throws<ArgumentException>(() => Calculator.ValidateNumbers(numbers));
        }


        [Test]
        public void ValidateNumbers_GreaterThan100()
        {
            numbers.Add(101);
            numbers.Add(50);

            Assert.Throws<ArgumentException>(() => Calculator.ValidateNumbers(numbers));
        }

        [Test]
        public void ValidateNumbers_All_Zero()
        {
            numbers.Add(0);
            numbers.Add(0);
            numbers.Add(0);

            Assert.Throws<ArgumentException>(() => Calculator.ValidateNumbers(numbers));
        }

        [Test]
        public void Test_ArithmeticMean()
        {
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            var arithmeticMean = Calculator.ArithmeticMean(numbers);

            Assert.That(arithmeticMean, Is.EqualTo(20));
        }

        [Test]
        public void Test_StandardDeviation()
        {
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            var standardDeviation = Calculator.StandardDeviation(numbers);

            Assert.That(standardDeviation, Is.EqualTo(8.16496580927726));
        }

        [Test]
        public void Test_FrequenciesOfNumbers()
        {
            var frequencies = new Dictionary<string, int>();
            frequencies.Add("10-19", 1);
            frequencies.Add("20-29", 1);
            frequencies.Add("30-39", 1);

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            var frequenciesOfNumbers = Calculator.FrequenciesOfNumbers(numbers, 10);

            Assert.That(frequenciesOfNumbers, Is.EqualTo(frequencies));
        }

        [Test]
        public void Test_SquareRoot()
        {
            var squareRoot = Calculator.SquareRoot(9);

            Assert.That(squareRoot, Is.EqualTo(3));
        }

        [Test]
        public void Test_SquareRoot_Negative_Value()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.SquareRoot(-9));
        }
    }
}