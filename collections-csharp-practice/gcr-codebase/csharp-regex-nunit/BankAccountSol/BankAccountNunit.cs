using NUnit.Framework;
using System;

namespace BankAccountNUnitTest
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount();
        }

        [Test]
        public void Deposit_Should_Increase_Balance()
        {
            account.Deposit(100);
            Assert.AreEqual(100, account.GetBalance());
        }

        [Test]
        public void Withdraw_Should_Decrease_Balance()
        {
            account.Deposit(200);
            account.Withdraw(50);
            Assert.AreEqual(150, account.GetBalance());
        }

        [Test]
        public void Withdraw_Insufficient_Funds_Should_Throw_Exception()
        {
            account.Deposit(50);

            Assert.Throws<InvalidOperationException>(() =>
            {
                account.Withdraw(100);
            });
        }
    }
}
