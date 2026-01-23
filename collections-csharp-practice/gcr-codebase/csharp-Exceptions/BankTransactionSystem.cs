using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}

class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
            throw new ArgumentException();

        if (amount > balance)
            throw new InsufficientFundsException("Insufficient balance!");

        balance -= amount;

        Console.WriteLine("Withdrawal successful, new balance: " + balance);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter initial balance: ");
            double balance = double.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(balance);

            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid amount!");
        }
    }
}
