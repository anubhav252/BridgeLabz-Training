using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathUtilsMSTest
{
    [TestClass]
    public class MathUtilsTests
    {
        private MathUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new MathUtils();
        }

        [TestMethod]
        public void Divide_By_Zero_Should_Throw_Exception()
        {
            Assert.ThrowsException<ArithmeticException>(() =>
            {
                utils.Divide(10, 0);
            });
        }
    }
}
