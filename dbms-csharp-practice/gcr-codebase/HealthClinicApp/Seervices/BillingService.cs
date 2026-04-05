using HealthCareApp.DataAccess;
using HealthCareApp.Interfaces;

namespace HealthCareApp.Services
{
    public class BillingService : IBillingService
    {
        private readonly BillingDAL dal = new BillingDAL();

        public void GenerateBill(int visitId, decimal amount)
            => dal.GenerateBill(visitId, amount);

        public void RecordPayment(int billId, string mode)
            => dal.RecordPayment(billId, mode);
    }
}
