using System;
using System.Reflection;
using System.Runtime.InteropServices;
namespace BankAccount
{
    public class BankMain
    {
        public double Balance{get;private set;}
        public BankMain(double currentBalance)
        {
            Balance=currentBalance;
        }

        public double DepositAmmount(double amount)
        {
            if (amount < 0)
            {
                throw new CustomException("Deposit amount cannot be negative");
            }
            return (Balance+=amount);
        }
        public void WithdrawAmount(double amount)
        {
            if (amount > Balance)
            {
                throw new CustomException("Insufficient fuunds");
            }
            System.Console.WriteLine("Balance : "+(Balance-=amount)); 
        }
    }
}
