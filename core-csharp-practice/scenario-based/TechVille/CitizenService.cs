using System;

class CitizenService
{
    public string Name;
    public int Age;
    public double Income;
    public int ResidencyYears;

    public static CitizenService ReadCitizen()
    {
        CitizenService citizen = new CitizenService();

        Console.Write("Name: ");
        citizen.Name = Console.ReadLine();

        Console.Write("Age: ");
        if (!int.TryParse(Console.ReadLine(), out citizen.Age) || citizen.Age <= 0)
            return null;

        Console.Write("Annual Income: ");
        if (!double.TryParse(Console.ReadLine(), out citizen.Income) || citizen.Income < 0)
            return null;

        Console.Write("Residency Years: ");
        if (!int.TryParse(Console.ReadLine(), out citizen.ResidencyYears) || citizen.ResidencyYears < 0)
            return null;

        return citizen;
    }

    public int CalculateScore()
    {
        int score = 0;

        if (Age >= 18)
        {
            score += 30;

            if (Income <= 300000)
            {
                score += 40;

                if (ResidencyYears >= 5)
                    score += 30;
            }
        }

        return score;
    }

    public string DeterminePackage(int score)
    {
        if (score >= 85 && ResidencyYears >= 10)
            return "Platinum";
        else if (score >= 70 && Income <= 500000)
            return "Gold";
        else if (score >= 50 && ResidencyYears >= 3)
            return "Silver";
        else
            return "Basic";
    }
}
