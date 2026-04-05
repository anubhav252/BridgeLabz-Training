using Microsoft.Data.SqlClient;

namespace HealthCareApp.DataAccess
{
    public class DbHelper
    {
        private static readonly string connectionString =
            "Server=localhost\\SQLEXPRESS;Database=HealthCareDatabase;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
