using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UserRegistrationTests
    {
        private UserRegistration registration;

        [TestInitialize]
        public void Setup()
        {
            registration = new UserRegistration();
        }

        [TestMethod]
        public void Valid_User_Registration_Should_Succeed()
        {
            bool result = registration.RegisterUser(
                "john_doe", "john@example.com", "Password1");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Empty_Username_Should_Throw_Exception()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                registration.RegisterUser("", "john@example.com", "Password1");
            });
        }

        [TestMethod]
        public void Invalid_Email_Should_Throw_Exception()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                registration.RegisterUser("john", "johnexample.com", "Password1");
            });
        }

        [TestMethod]
        public void Short_Password_Should_Throw_Exception()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                registration.RegisterUser("john", "john@example.com", "123");
            });
        }
    }
}
