using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConverterMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        private TemperatureConverter converter;

        [TestInitialize]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }

        [TestMethod]
        public void CelsiusToFahrenheit_Test()
        {
            double result = converter.CelsiusToFahrenheit(0);
            Assert.AreEqual(32, result, 0.01);
        }

        [TestMethod]
        public void FahrenheitToCelsius_Test()
        {
            double result = converter.FahrenheitToCelsius(212);
            Assert.AreEqual(100, result, 0.01);
        }
    }
}
