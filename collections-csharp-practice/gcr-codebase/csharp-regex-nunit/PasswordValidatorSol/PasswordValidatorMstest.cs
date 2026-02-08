using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordValidatorMSTest
{
    [TestClass]
    public class PasswordValidatorTests
    {
        private PasswordValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new PasswordValidator();
        }

        [TestMethod]
        public void Valid_Password_Should_Return_True()
        {
            Assert.IsTrue(validator.IsValid("StrongPass1"));
        }

        [TestMethod]
        public void Password_Too_Short_Should_Return_False()
        {
            Assert.IsFalse(validator.IsValid("Abc1"));
        }

        [TestMethod]
        public void Password_Without_Uppercase_Should_Return_False()
        {
            Assert.IsFalse(validator.IsValid("password1"));
        }

        [TestMethod]
        public void Password_Without_Digit_Should_Return_False()
        {
            Assert.IsFalse(validator.IsValid("Password"));
        }
    }
}
