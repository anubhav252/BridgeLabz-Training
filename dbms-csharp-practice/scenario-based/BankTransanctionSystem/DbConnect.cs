using System;
using Microsoft.Data.SqlClient;
namespace BankTransactionSystem
{
    static class DbConnect
    {
        public static string ConnectionString=>"Server=localhost\\SQLEXPRESS;Database=BankDatabase;Trusted_Connection=true;TrustServerCertificate=true;";
        
    }
}