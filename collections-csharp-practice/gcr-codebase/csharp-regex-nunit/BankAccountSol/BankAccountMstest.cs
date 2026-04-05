using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankAccountMSTest
{
    [TestClass]
    public class BankAccountTests
    {
        private BankAccount account;

        [TestInitialize]
        public void Setup()
        {
            account = new BankAccount();
        }

        [TestMethod]
        public void Deposit_Should_Increase_Balance()
        {
            account.Deposit(100);
            Assert.AreEqual(100, account.GetBalance());
        }

        [TestMethod]
        public void Withdraw_Should_Decrease_Balance()
        {
            account.Deposit(200);
            account.Withdraw(50);
            Assert.AreEqual(150, account.GetBalance());
        }

        [TestMethod]
        public void Withdraw_Insufficient_Funds_Should_Throw_Exception()
        {
            account.Deposit(50);

            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                account.Withdraw(100);
            });
        }
    }
}
