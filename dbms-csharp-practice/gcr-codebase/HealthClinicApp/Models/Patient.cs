using System;

namespace HealthCareApp.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime DOB { get; set; }
        public string Contact { get; set; }
        public string PatientAddress { get; set; }
        public string BloodGroup { get; set; }
    }
}
