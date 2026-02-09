namespace HealthCareApp.Interfaces
{
    public interface IBillingService
    {
        void GenerateBill(int visitId, decimal amount);
        void RecordPayment(int billId, string mode);
    }
}
