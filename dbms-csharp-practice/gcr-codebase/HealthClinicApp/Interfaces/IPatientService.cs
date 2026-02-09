using System.Data;
using HealthCareApp.Models;

namespace HealthCareApp.Interfaces
{
    public interface IPatientService
    {
        void RegisterPatient(Patient patient);
        void UpdatePatient(Patient patient);
        DataTable SearchPatient(string search);
    }
}
