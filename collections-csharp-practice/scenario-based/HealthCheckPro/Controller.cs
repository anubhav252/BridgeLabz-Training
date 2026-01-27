using System;

class LabController
{
    [PublicAPI]
    public void GetAllTests()
    {
    }

    [PublicAPI]
    [RequiresAuth("Doctor")]
    public void GetPatientReport()
    {
    }

    public void InternalAudit()
    {
    }
}

class BillingController
{
    [PublicAPI]
    public void GenerateInvoice()
    {
    }

    [RequiresAuth("Admin")]
    public void UpdatePrices()
    {
    }
}
