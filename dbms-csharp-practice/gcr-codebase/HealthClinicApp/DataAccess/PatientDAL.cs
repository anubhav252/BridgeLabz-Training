using Microsoft.Data.SqlClient;
using System.Data;
using HealthCareApp.Models;

namespace HealthCareApp.DataAccess
{
    public class PatientDAL
    {
        public void AddPatient(Patient p)
        {
            using var con = DbHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("AddPatient", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PatientName", p.PatientName);
            cmd.Parameters.AddWithValue("@DOB", p.DOB);
            cmd.Parameters.AddWithValue("@Contact", p.Contact);
            cmd.Parameters.AddWithValue("@PatientAddress", p.PatientAddress);
            cmd.Parameters.AddWithValue("@BloodGroup", p.BloodGroup);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void UpdatePatient(Patient p)
        {
            using var con = DbHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("UpdatePatient", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PatientId", p.PatientId);
            cmd.Parameters.AddWithValue("@PatientName", p.PatientName);
            cmd.Parameters.AddWithValue("@Contact", p.Contact);
            cmd.Parameters.AddWithValue("@PatientAddress", p.PatientAddress);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public DataTable SearchPatient(string search)
        {
            DataTable dt = new DataTable();
            using var con = DbHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("SearchPatient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Search", search);

            new SqlDataAdapter(cmd).Fill(dt);
            return dt;
        }
    }
}
