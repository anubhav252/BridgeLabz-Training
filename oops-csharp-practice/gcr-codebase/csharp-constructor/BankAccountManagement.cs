using System;

class BankAccount{
    public long accountNumber;
    protected string accountHolder;
    private double balance;

    public BankAccount(long accountNumber, string accountHolder, double balance){
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public double GetBalance(){
        return balance;
    }

    public void Deposit(double amount){
        if (amount > 0)
            balance += amount;
    }

    public void Withdraw(double amount){
        if (amount > 0 && amount <= balance)
            balance -= amount;
    }

    public void DisplayAccount(){
        Console.WriteLine("Account Number : " + accountNumber);
        Console.WriteLine("Account Holder : " + accountHolder);
        Console.WriteLine("Balance        : " + balance);
        Console.WriteLine("----------------------------");
    }
}

class SavingsAccount : BankAccount{
    private double interestRate;

    public SavingsAccount(long accountNumber, string accountHolder, double balance, double interestRate)
        : base(accountNumber, accountHolder, balance)
    {
        this.interestRate = interestRate;
    }

    public void DisplaySavingsAccount()
    {
        Console.WriteLine("Account Number : " + accountNumber);
        Console.WriteLine("Account Holder : " + accountHolder);
        Console.WriteLine("Interest Rate  : " + interestRate + "%");
        Console.WriteLine("Balance        : " + GetBalance());
        Console.WriteLine("----------------------------");
    }
}

class BankAccountManagement{
    static void Main(string[] args){
        BankAccount acc = new BankAccount(1234567890, "Anubhav", 5000);
        acc.DisplayAccount();

        acc.Deposit(2000);
        acc.Withdraw(1000);
        Console.WriteLine("Updated Balance: " + acc.GetBalance());
        Console.WriteLine();

        SavingsAccount sav = new SavingsAccount(9876543210, "Rohit", 10000, 4.5);
        sav.DisplaySavingsAccount();
    }
}
