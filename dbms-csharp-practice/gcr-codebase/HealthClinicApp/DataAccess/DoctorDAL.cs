using Microsoft.Data.SqlClient;
using HealthCareApp.Models;
using System.Data;

namespace HealthCareApp.DataAccess
{
    public class DoctorDAL
    {
        public void AddDoctor(Doctor d)
        {
            using var con = DbHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("AddDoctor", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DoctorName", d.DoctorName);
            cmd.Parameters.AddWithValue("@SpecialityId", d.SpecialityId);
            cmd.Parameters.AddWithValue("@Contact", d.Contact);
            cmd.Parameters.AddWithValue("@ConsultationFee", d.ConsultationFee);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
