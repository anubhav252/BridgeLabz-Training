using System;
using System.Data;

namespace HealthCareApp.Interfaces
{
    public interface IAppointmentService
    {
        void BookAppointment(int patientId, int doctorId, DateTime date);
        void CancelAppointment(int appointmentId);
        DataTable DailySchedule(DateTime date);
    }
}
