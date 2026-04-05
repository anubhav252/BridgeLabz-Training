using System;

class BankAccount{
    protected long AccountNumber;
    protected double Balance;

    public BankAccount(long accountNumber, double balance){
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual void DisplayAccountDetails(){
        Console.WriteLine("Account Number : " + AccountNumber);
        Console.WriteLine("Balance        : " + Balance);
    }
}

class SavingsAccount : BankAccount{
    private double InterestRate;

    public SavingsAccount(long accountNumber, double balance, double interestRate)
        : base(accountNumber, balance){
        InterestRate = interestRate;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Account Type   : Savings Account");
        DisplayAccountDetails();
        Console.WriteLine("Interest Rate : " + InterestRate + "%");
        Console.WriteLine("------------------------------");
    }
}

class CheckingAccount : BankAccount{
    private double WithdrawalLimit;

    public CheckingAccount(long accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance){
        WithdrawalLimit = withdrawalLimit;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Account Type     : Checking Account");
        DisplayAccountDetails();
        Console.WriteLine("Withdrawal Limit : " + WithdrawalLimit);
        Console.WriteLine("------------------------------");
    }
}

class FixedDepositAccount : BankAccount{
    private int MaturityPeriod;

    public FixedDepositAccount(long accountNumber, double balance, int maturityPeriod)
        : base(accountNumber, balance)
    {
        MaturityPeriod = maturityPeriod;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type     : Fixed Deposit Account");
        DisplayAccountDetails();
        Console.WriteLine("Maturity Period  : " + MaturityPeriod + " months");
        Console.WriteLine("------------------------------");
    }
}

class BankAccountTypes{
    static void Main(string[] args){
        SavingsAccount sa = new SavingsAccount(1001, 50000, 4.5);
        CheckingAccount ca = new CheckingAccount(1002, 30000, 20000);
        FixedDepositAccount fda = new FixedDepositAccount(1003, 100000, 24);

        sa.DisplayAccountType();
        ca.DisplayAccountType();
        fda.DisplayAccountType();
    }
}
