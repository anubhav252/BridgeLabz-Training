using System;
class BonusUsingMethod{
    static void Main(string[] args){
        double[,] employeeData = GenerateEmployeeData();
        double[,] updatedData = CalculateBonusAndNewSalary(employeeData);

        CalculateAndDisplayTotals(employeeData, updatedData);
    }

    static double[,] GenerateEmployeeData(){
        double[,] data = new double[10, 2];
        Random random = new Random();

        for (int i = 0; i < 10; i++){
            data[i, 0] = random.Next(10000, 100000);
            data[i, 1] = random.Next(1, 11);
        }

        return data;
    }

    static double[,] CalculateBonusAndNewSalary(double[,] employeeData){
        double[,] updated = new double[10, 2];

        for (int i = 0; i < 10; i++){
            double salary = employeeData[i, 0];
            double years = employeeData[i, 1];

            double bonusRate = years > 5 ? 0.05 : 0.02;
            double bonus = salary * bonusRate;
            double newSalary = salary + bonus;

            updated[i, 0] = newSalary;
            updated[i, 1] = bonus;
        }

        return updated;
    }

    static void CalculateAndDisplayTotals(double[,] oldData, double[,] newData){
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Emp\tOldSalary\tYears\tBonus\t\tNewSalary");

        for (int i = 0; i < 10; i++){
            double oldSalary = oldData[i, 0];
            double years = oldData[i, 1];
            double bonus = newData[i, 1];
            double newSalary = newData[i, 0];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine(
                (i + 1) + "\t" +
                oldSalary + "\t" +
                years + "\t" +
                bonus + "\t" +
                newSalary
            );
        }

        Console.WriteLine("\nTotal Old Salary = " + totalOldSalary);
        Console.WriteLine("Total Bonus = " + totalBonus);
        Console.WriteLine("Total New Salary = " + totalNewSalary);
    }
}
