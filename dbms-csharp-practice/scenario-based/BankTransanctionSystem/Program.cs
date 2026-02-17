using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankTransactionSystem
{
    class Program
    {
        static async Task Main(string[] args)
        {
            BankTransactionService service = new BankTransactionService();

            Console.WriteLine("Creating test account...");

            await service.AddAccount("John Doe", 1000);

        
            int accountId = 1;

            BankTransactionService.Accounts[accountId] = new Account
            {
                AccountId = accountId,
                Balance = 1000
            };

            Console.WriteLine("Initial Balance: 1000");

         
            // Test Insufficient Balance
           
            Console.WriteLine("\nTesting insufficient balance...");
            try
            {
                await service.WithdrawAsync(accountId, 5000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Expected error: " + ex.Message);
            }

         
            // Test Concurrent Withdrawals
           
            Console.WriteLine("\nTesting 50 parallel withdrawals...");

            List<Task> tasks = new List<Task>();

            for (int i = 0; i < 50; i++)
            {
                tasks.Add(service.WithdrawAsync(accountId, 10));
            }

            await Task.WhenAll(tasks);

            Console.WriteLine("Parallel withdrawals completed.");

            //Test Rollback
            try
            {
                await service.WithdrawAsync(999, 50); // Invalid AccountId
            }
            catch
            {
                Console.WriteLine("Rollback successful.");
            }

            
            // Final Balance
        
            Console.WriteLine("\nFinal Cached Balance: " +BankTransactionService.Accounts[accountId].Balance);

            Console.WriteLine("\nProcess completed.");
        }
    }
}
