namespace HealthCareApp.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int SpecialityId { get; set; }
        public string Contact { get; set; }
        public decimal ConsultationFee { get; set; }
    }
}
