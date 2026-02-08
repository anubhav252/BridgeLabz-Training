using NUnit.Framework;
using System;

namespace MathUtilsNUnitTest
{
    [TestFixture]
    public class MathUtilsTests
    {
        private MathUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new MathUtils();
        }

        [Test]
        public void Divide_By_Zero_Should_Throw_Exception()
        {
            Assert.Throws<ArithmeticException>(() =>
            {
                utils.Divide(10, 0);
            });
        }
    }
}
