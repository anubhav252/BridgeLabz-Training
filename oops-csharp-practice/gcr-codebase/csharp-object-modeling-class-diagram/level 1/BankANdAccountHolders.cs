using System;
using System.Collections.Generic;

class Bank{
    public string BankName;
    private Dictionary<Customer, double> accounts;

    public Bank(string bankName){
        BankName = bankName;
        accounts = new Dictionary<Customer, double>();
    }

    public void OpenAccount(Customer customer, double initialBalance){
        if (!accounts.ContainsKey(customer)){
            accounts.Add(customer, initialBalance);
            Console.WriteLine("Account opened for " + customer.Name + " in " + BankName);
        }
    }

    public double GetBalance(Customer customer){
        if (accounts.ContainsKey(customer))
            return accounts[customer];

        return 0;
    }
}

class Customer{
    public string Name;

    public Customer(string name){
        Name = name;
    }

    public void ViewBalance(Bank bank){
        double balance = bank.GetBalance(this);
        Console.WriteLine(Name + "'s balance in " + bank.BankName + " : " + balance);
    }
}

class BankAndAccountHolders{
    static void Main(string[] args){
        Bank bank = new Bank("City Bank");

        Customer c1 = new Customer("Anubhav");
        Customer c2 = new Customer("Rohit");

        bank.OpenAccount(c1, 5000);
        bank.OpenAccount(c2, 10000);

        c1.ViewBalance(bank);
        c2.ViewBalance(bank);
    }
}
