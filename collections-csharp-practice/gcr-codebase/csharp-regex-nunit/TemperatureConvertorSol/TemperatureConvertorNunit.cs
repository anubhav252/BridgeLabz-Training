using NUnit.Framework;

namespace TemperatureConverterNUnitTest
{
    [TestFixture]
    public class TemperatureConverterTests
    {
        private TemperatureConverter converter;

        [SetUp]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }

        [Test]
        public void CelsiusToFahrenheit_Test()
        {
            double result = converter.CelsiusToFahrenheit(0);
            Assert.AreEqual(32, result, 0.01);
        }

        [Test]
        public void FahrenheitToCelsius_Test()
        {
            double result = converter.FahrenheitToCelsius(212);
            Assert.AreEqual(100, result, 0.01);
        }
    }
}
