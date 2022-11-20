using System;
using CalculatorTwo;

namespace CalculatorTwoTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_CompoundIncrease()
        {
            var compoundIncrease = Calculator.CompoundIncrease(100,10,5);

            Assert.That(compoundIncrease, Is.EqualTo(161.051));
        }

        [Test]
        public void Test_CompoundIncrease_Negative_Value()
        {
            Assert.Throws<ArgumentException>(() => Calculator.CompoundIncrease(-100, 10, 5));
        }

        [Test]
        public void Test_CompoundDecrease()
        {
            var compoundDecrease = Calculator.CompoundDecrease(100, 10, 5);

            Assert.That(compoundDecrease, Is.EqualTo(59.049));
        }

        [Test]
        public void Test_CompoundDecrease_Negative_Value()
        {
            Assert.Throws<ArgumentException>(() => Calculator.CompoundDecrease(-100, 10, 5));
        }

    }
}