using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class CurrentAccount : BankAccount, ILoanable
    {
        private const double INTEREST_RATE = 0.02; // 2%

        public CurrentAccount(long accNo, string name, double balance)
            : base(accNo, name, balance) { }

        public override double CalculateInterest()
        {
            return Balance * INTEREST_RATE;
        }

        public void ApplyForLoan()
        {
            Console.WriteLine("Loan applied under Current Account");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 10; 
        }
    }
}
