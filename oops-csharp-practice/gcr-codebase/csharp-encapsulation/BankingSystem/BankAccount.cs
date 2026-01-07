using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    abstract class BankAccount
    {
        private long accountNumber;
        private string holderName;
        private double balance;

        public long AccountNumber
        {
            get { return accountNumber; }
            protected set { accountNumber = value; }
        }

        public string HolderName
        {
            get { return holderName; }
            protected set { holderName = value; }
        }

        public double Balance
        {
            get { return balance; }
            protected set
            {
                if (value >= 0)
                    balance = value;
            }
        }

        public BankAccount(long accNo, string name, double initialBalance)
        {
            AccountNumber = accNo;
            HolderName = name;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        public abstract double CalculateInterest();

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Holder Name    : " + HolderName);
            Console.WriteLine("Balance        : " + Balance);
        }
    }
}
