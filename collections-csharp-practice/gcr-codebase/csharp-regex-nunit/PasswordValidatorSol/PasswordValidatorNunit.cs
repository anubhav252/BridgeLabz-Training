using NUnit.Framework;

namespace PasswordValidatorNUnitTest
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        private PasswordValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new PasswordValidator();
        }

        [Test]
        public void Valid_Password_Should_Return_True()
        {
            Assert.IsTrue(validator.IsValid("StrongPass1"));
        }

        [Test]
        public void Password_Too_Short_Should_Return_False()
        {
            Assert.IsFalse(validator.IsValid("Abc1"));
        }

        [Test]
        public void Password_Without_Uppercase_Should_Return_False()
        {
            Assert.IsFalse(validator.IsValid("password1"));
        }

        [Test]
        public void Password_Without_Digit_Should_Return_False()
        {
            Assert.IsFalse(validator.IsValid("Password"));
        }
    }
}
