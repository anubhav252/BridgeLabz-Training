using System.Collections.Concurrent;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BankTransactionSystem
{
    class BankTransactionService
    {
        public static ConcurrentDictionary<int, Account> Accounts =new ConcurrentDictionary<int, Account>();
        public static object LockObj = new object();
        public async Task AddAccount(string holderName,double balance)
        {
            using SqlConnection connect=new SqlConnection(DbConnect.ConnectionString);
            connect.Open();
            string query="INSERT INTO Accounts(HolderName,Balance) VALUES (@holderName,@balance)";
            using SqlCommand cmd=new SqlCommand(query,connect);
            cmd.Parameters.AddWithValue("@holderName",holderName);
            cmd.Parameters.AddWithValue("@balance",balance);
            int row =cmd.ExecuteNonQuery();
            System.Console.WriteLine($"{row} row inserted");
        }
         public async Task WithdrawAsync(int accountId, decimal amount)
        {
            using SqlConnection con =new SqlConnection(DbConnect.ConnectionString);

            await con.OpenAsync();

            using SqlCommand cmd =new SqlCommand("WithdrawAmount", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccountId", SqlDbType.Int).Value = accountId;
            cmd.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;

            await cmd.ExecuteNonQueryAsync();

            BankTransactionService.Accounts.AddOrUpdate(accountId,id => throw new Exception("Account not found"),(id, oldAccount) =>
            {
                if (oldAccount.Balance < amount)
                    throw new Exception("Insufficient balance");
                return new Account
                {
                    AccountId = id,
                    Balance = oldAccount.Balance - amount
                };
            });
        }
    }
}