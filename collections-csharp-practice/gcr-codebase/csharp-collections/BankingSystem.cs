using System;
using System.Collections.Generic;

class BankingSystem
{
    static void Main()
    {
        Dictionary<int, double> accounts = new Dictionary<int, double>();
        SortedDictionary<double, List<int>> sortedByBalance =new SortedDictionary<double, List<int>>();
        Queue<(int accountNumber, double amount)> withdrawalQueue =new Queue<(int, double)>();

        accounts[101] = 5000;
        accounts[102] = 12000;
        accounts[103] = 3000;
        accounts[104] = 8000;

        withdrawalQueue.Enqueue((101, 2000));
        withdrawalQueue.Enqueue((103, 1000));
        withdrawalQueue.Enqueue((102, 5000));
        withdrawalQueue.Enqueue((104, 9000));

        Console.WriteLine("Processing Withdrawals:");

        while (withdrawalQueue.Count > 0)
        {
            var request = withdrawalQueue.Dequeue();
            int accNo = request.accountNumber;
            double amount = request.amount;

            if (accounts.ContainsKey(accNo) && accounts[accNo] >= amount)
            {
                accounts[accNo] -= amount;
                Console.WriteLine($"Account {accNo}: Withdrawn {amount}");
            }
            else
            {
                Console.WriteLine($"Account {accNo}: Insufficient balance");
            }
        }

        foreach (var acc in accounts)
        {
            double balance = acc.Value;

            if (!sortedByBalance.ContainsKey(balance))
                sortedByBalance[balance] = new List<int>();

            sortedByBalance[balance].Add(acc.Key);
        }

        Console.WriteLine("\nAccounts Sorted by Balance:");

        foreach (var entry in sortedByBalance)
        {
            foreach (int accNo in entry.Value)
                Console.WriteLine($"Account {accNo} : {entry.Key}");
        }
    }
}
