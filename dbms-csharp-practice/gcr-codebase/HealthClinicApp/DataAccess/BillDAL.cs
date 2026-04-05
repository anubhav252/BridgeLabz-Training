using Microsoft.Data.SqlClient;
using System.Data;

namespace HealthCareApp.DataAccess
{
    public class BillingDAL
    {
        public void GenerateBill(int visitId, decimal amount)
        {
            using var con = DbHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("GenerateBill", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@VisitId", visitId);
            cmd.Parameters.AddWithValue("@TotalAmount", amount);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void RecordPayment(int billId, string mode)
        {
            using var con = DbHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("RecordPayment", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@BillId", billId);
            cmd.Parameters.AddWithValue("@PaymentMode", mode);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
