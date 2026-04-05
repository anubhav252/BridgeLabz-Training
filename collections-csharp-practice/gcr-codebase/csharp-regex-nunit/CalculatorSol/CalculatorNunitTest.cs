using NUnit.Framework;
using System;

namespace CalculatorNUnitTest
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_Test()
        {
            int result = calc.Add(10, 5);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Subtract_Test()
        {
            int result = calc.Subtract(10, 5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Multiply_Test()
        {
            int result = calc.Multiply(10, 5);
            Assert.AreEqual(50, result);
        }

        [Test]
        public void Divide_Test()
        {
            int result = calc.Divide(10, 5);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide_By_Zero_Test()
        {
            Assert.Throws<DivideByZeroException>(() =>{calc.Divide(10, 0);});
        }
    }
}
