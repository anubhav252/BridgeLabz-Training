using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  BankingSystem
{
    internal interface ILoanable
    {
        void ApplyForLoan();
        double CalculateLoanEligibility();
    }
}
