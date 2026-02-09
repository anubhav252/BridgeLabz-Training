using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace HealthCareApp.DataAccess
{
    public class AppointmentDAL
    {
        public void Book(int patientId, int doctorId, DateTime date)
        {
            using var con = DbHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("BookAppointment", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PatientId", patientId);
            cmd.Parameters.AddWithValue("@DoctorId", doctorId);
            cmd.Parameters.AddWithValue("@AppointmentDate", date);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void Cancel(int appointmentId)
        {
            using var con = DbHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("CancelAppointment", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public DataTable DailySchedule(DateTime date)
        {
            DataTable dt = new DataTable();
            using var con = DbHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("DailyAppointments", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Date", date);

            new SqlDataAdapter(cmd).Fill(dt);
            return dt;
        }
    }
}
