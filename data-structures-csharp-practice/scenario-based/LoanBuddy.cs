using System;

namespace LoanBuddy
{
    class Applicant
    {
        public string Name { get; }
        private int creditScore;
        private double income;
        private double loanAmount;

        public Applicant(string name, int creditScore, double income, double loanAmount)
        {
            Name = name;
            this.creditScore = creditScore;
            this.income = income;
            this.loanAmount = loanAmount;
        }

        internal int CreditScore => creditScore;
        internal double Income => income;
        internal double LoanAmount => loanAmount;
    }

    interface IApprovable
    {
        bool ApproveLoan(Applicant applicant);
        double CalculateEMI(Applicant applicant);
    }

    abstract class LoanApplication : IApprovable
    {
        protected string loanType;
        protected int termInMonths;
        protected double annualInterestRate;
        private bool isApproved;

        protected LoanApplication(string loanType, int termInMonths, double annualInterestRate)
        {
            this.loanType = loanType;
            this.termInMonths = termInMonths;
            this.annualInterestRate = annualInterestRate;
            isApproved = false;
        }

        protected void SetApprovalStatus(bool status)
        {
            isApproved = status;
        }

        public bool IsApproved => isApproved;

        protected double CalculateEmiFormula(double principal)
        {
            double monthlyRate = annualInterestRate / (12 * 100);
            int n = termInMonths;

            return (principal * monthlyRate * Math.Pow(1 + monthlyRate, n)) /
                   (Math.Pow(1 + monthlyRate, n) - 1);
        }

        public abstract bool ApproveLoan(Applicant applicant);
        public abstract double CalculateEMI(Applicant applicant);
    }

    class PersonalLoan : LoanApplication
    {
        public PersonalLoan(int termInMonths)
            : base("Personal Loan", termInMonths, 14.5) { }

        public override bool ApproveLoan(Applicant applicant)
        {
            bool eligible = applicant.CreditScore >= 650 &&
                            applicant.Income >= 30000;

            SetApprovalStatus(eligible);
            return eligible;
        }

        public override double CalculateEMI(Applicant applicant)
        {
            return CalculateEmiFormula(applicant.LoanAmount);
        }
    }

    class HomeLoan : LoanApplication
    {
        public HomeLoan(int termInMonths)
            : base("Home Loan", termInMonths, 8.5) { }

        public override bool ApproveLoan(Applicant applicant)
        {
            bool eligible = applicant.CreditScore >= 700 &&
                            applicant.Income >= 50000;

            SetApprovalStatus(eligible);
            return eligible;
        }

        public override double CalculateEMI(Applicant applicant)
        {
            return CalculateEmiFormula(applicant.LoanAmount);
        }
    }

    class AutoLoan : LoanApplication
    {
        public AutoLoan(int termInMonths)
            : base("Auto Loan", termInMonths, 10.0) { }

        public override bool ApproveLoan(Applicant applicant)
        {
            bool eligible = applicant.CreditScore >= 680 &&
                            applicant.Income >= 35000;

            SetApprovalStatus(eligible);
            return eligible;
        }

        public override double CalculateEMI(Applicant applicant)
        {
            return CalculateEmiFormula(applicant.LoanAmount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Applicant applicant = new Applicant(
                "Rahul Sharma",
                720,
                60000,
                500000
            );

            LoanApplication loan = new HomeLoan(240);

            if (loan.ApproveLoan(applicant))
            {
                double emi = loan.CalculateEMI(applicant);
                Console.WriteLine("Loan Approved for " + applicant.Name);
                Console.WriteLine("Monthly EMI: " + emi.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Loan Rejected for " + applicant.Name);
            }
        }
    }
}
