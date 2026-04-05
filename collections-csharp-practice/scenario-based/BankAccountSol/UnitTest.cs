using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
namespace BankAccountTest
{
    [TestClass]
    public class UnitTest
    {
        private BankMain bank; 

        [TestInitialize]
        public void Setup()
        {
            bank=new BankMain(2000);
        }

        [TestMethod]
        public void Test_Deposit_ValidAmount()
        {
            Assert.AreEqual(4000,bank.DepositAmmount(2000));
        }
        [TestMethod]
        public void Test_Deposit_NegativeAmount()
        {
            try
            {
                bank.DepositAmmount(-700);
            }
            catch(CustomException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void Test_Withdraw_ValidAmount()
        {
            bank.WithdrawAmount(500);
            Assert.AreEqual(1500,bank.Balance);
        }
        [TestMethod]
        public void Test_Withdraw_InsufficientFunds()
        {
            Assert.Throws<CustomException>(()=>bank.WithdrawAmount(3000));
        }
    }
}