
using System;

class TechVilleMain
{
    static void Main()
    {
        // Input Section
        Console.Write("Enter citizen name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter annual income: ");
        double income = double.Parse(Console.ReadLine());

        Console.Write("Enter years of residency: ");
        int residencyYears = int.Parse(Console.ReadLine());

        // Validation
        if (age <= 0 || income < 0 || residencyYears < 0)
        {
            Console.WriteLine("Invalid input! Please enter valid details.");
            return;
        }

        int eligibilityScore = 0;

        // Eligibility Calculation
        if (age >= 18)
            eligibilityScore += 30;

        if (income <= 300000)
            eligibilityScore += 40;

        if (residencyYears >= 5)
            eligibilityScore += 30;

        bool isEligible = eligibilityScore >= 60;

        // Output Section
        Console.WriteLine("\n--- TechVille Citizen Profile ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Income: ₹" + income);
        Console.WriteLine("Residency Years: " + residencyYears);
        Console.WriteLine("Eligibility Score: " + eligibilityScore);
        Console.WriteLine("Service Status: " + (isEligible ? "Eligible" : "Not Eligible"));
    }
}
