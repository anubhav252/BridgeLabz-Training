using NUnit.Framework;
using System;

namespace UserRegistrationNUnitTest
{
    [TestFixture]
    public class UserRegistrationTests
    {
        private UserRegistration registration;

        [SetUp]
        public void Setup()
        {
            registration = new UserRegistration();
        }

        [Test]
        public void Valid_User_Registration_Should_Succeed()
        {
            bool result = registration.RegisterUser(
                "john_doe", "john@example.com", "Password1");

            Assert.IsTrue(result);
        }

        [Test]
        public void Empty_Username_Should_Throw_Exception()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                registration.RegisterUser("", "john@example.com", "Password1");
            });
        }

        [Test]
        public void Invalid_Email_Should_Throw_Exception()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                registration.RegisterUser("john", "johnexample.com", "Password1");
            });
        }

        [Test]
        public void Short_Password_Should_Throw_Exception()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                registration.RegisterUser("john", "john@example.com", "123");
            });
        }
    }
}
