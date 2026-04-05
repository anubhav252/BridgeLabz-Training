using System;
using System.Data;
using HealthCareApp.DataAccess;
using HealthCareApp.Interfaces;

namespace HealthCareApp.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly AppointmentDAL dal = new AppointmentDAL();

        public void BookAppointment(int patientId, int doctorId, DateTime date)
            => dal.Book(patientId, doctorId, date);

        public void CancelAppointment(int appointmentId)
            => dal.Cancel(appointmentId);

        public DataTable DailySchedule(DateTime date)
            => dal.DailySchedule(date);
    }
}
