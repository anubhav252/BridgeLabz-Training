using System;

class TechvilleMain
{
    static void Main()
    {
        ServiceEligibility eligibility = new ServiceEligibility();
        eligibility.StartRegistration();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}