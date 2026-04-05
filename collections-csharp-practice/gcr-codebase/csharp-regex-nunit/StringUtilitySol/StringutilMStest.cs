using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringUtilsMSTest
{
    [TestClass]
    public class StringUtilsTests
    {
        private StringUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new StringUtils();
        }

        [TestMethod]
        public void Reverse_Test()
        {
            string result = utils.Reverse("hello");
            Assert.AreEqual("olleh", result);
        }

        [TestMethod]
        public void IsPalindrome_True_Test()
        {
            bool result = utils.IsPalindrome("madam");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_False_Test()
        {
            bool result = utils.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ToUpperCase_Test()
        {
            string result = utils.ToUpperCase("hello");
            Assert.AreEqual("HELLO", result);
        }
    }
}
