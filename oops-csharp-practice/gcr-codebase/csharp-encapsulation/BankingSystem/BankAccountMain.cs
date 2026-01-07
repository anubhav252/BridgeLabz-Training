using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class BankAccountMain
    {
        static void Main(string[] args)
        {
            BankAccount[] accounts =
            {
                new SavingsAccount(10101, "Sam", 50000),
                new CurrentAccount(20202, "Alex", 100000)
            };

            foreach (BankAccount account in accounts)
            {
                account.DisplayDetails();

                double interest = account.CalculateInterest();
                Console.WriteLine("Interest Earned: " + interest);

                if (account is ILoanable loanable)
                {
                    loanable.ApplyForLoan();
                    Console.WriteLine("Loan Eligibility: " +
                        loanable.CalculateLoanEligibility());
                }

                Console.WriteLine("---------------------------");
            }
        }
    }
}
