using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class SavingsAccount : BankAccount, ILoanable
    {
        private const double INTEREST_RATE = 0.04; // 4%

        public SavingsAccount(long accNo, string name, double balance)
            : base(accNo, name, balance) { }

        public override double CalculateInterest()
        {
            return Balance * INTEREST_RATE;
        }

        public void ApplyForLoan()
        {
            Console.WriteLine("Loan applied under Savings Account");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 5; // 5 times balance
        }
    }

}
