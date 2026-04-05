using HealthCareApp.Models;
using HealthCareApp.DataAccess;
using HealthCareApp.Interfaces;

namespace HealthCareApp.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly DoctorDAL dal = new DoctorDAL();
        public void AddDoctor(Doctor doctor) => dal.AddDoctor(doctor);
    }
}
