using System.Data;
using HealthCareApp.Models;
using HealthCareApp.DataAccess;
using HealthCareApp.Interfaces;

namespace HealthCareApp.Services
{
    public class PatientService : IPatientService
    {
        private readonly PatientDAL dal = new PatientDAL();

        public void RegisterPatient(Patient patient) => dal.AddPatient(patient);
        public void UpdatePatient(Patient patient) => dal.UpdatePatient(patient);
        public DataTable SearchPatient(string search) => dal.SearchPatient(search);
    }
}
