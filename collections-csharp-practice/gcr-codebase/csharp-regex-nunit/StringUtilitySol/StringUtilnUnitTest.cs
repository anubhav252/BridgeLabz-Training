using NUnit.Framework;

namespace StringUtilsNUnitTest
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new StringUtils();
        }

        [Test]
        public void Reverse_Test()
        {
            string result = utils.Reverse("hello");
            Assert.AreEqual("olleh", result);
        }

        [Test]
        public void IsPalindrome_True_Test()
        {
            bool result = utils.IsPalindrome("madam");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_False_Test()
        {
            bool result = utils.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [Test]
        public void ToUpperCase_Test()
        {
            string result = utils.ToUpperCase("hello");
            Assert.AreEqual("HELLO", result);
        }
    }
}
