using System;
using System.Collections.Generic;

class ServiceEligibility
{
    public void StartRegistration()
    {
        Console.Write("Enter number of family members to register: ");
        int memberCount = int.Parse(Console.ReadLine());

        List<string> registeredMembers = new List<string>();

        for (int i = 1; i <= memberCount; i++)
        {
            Console.WriteLine($"\nRegistering Family Member #{i}");

            CitizenService citizen = CitizenService.ReadCitizen();

            if (citizen == null)
            {
                Console.WriteLine("Invalid data! Skipping member...");
                continue;
            }

            int score = citizen.CalculateScore();
            string package = citizen.DeterminePackage(score);
            string status = score >= 60 ? "Eligible" : "Not Eligible";

            Console.WriteLine("\n--- Service Summary ---");
            Console.WriteLine($"Name: {citizen.Name}");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine($"Status: {status}");
            Console.WriteLine($"Package: {package}");

            registeredMembers.Add(citizen.Name);
        }

        Console.WriteLine("\nRegistered Family Members:");
        foreach (string member in registeredMembers)
        {
            Console.WriteLine("- " + member);
        }
    }
}
