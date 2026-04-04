using System;
class GradeUsingMethod{
    static void Main(string[] args){
        int numberOfStudents = int.Parse(Console.ReadLine());

        double[,] pcmScores = GeneratePCMScores(numberOfStudents);
        double[,] results = CalculateTotalAveragePercentage(pcmScores);
        DisplayScoreCard(pcmScores, results);
    }

    static double[,] GeneratePCMScores(int count){
        double[,] scores = new double[count, 3];
        Random random = new Random();

        for (int i = 0; i < count; i++){
            scores[i, 0] = random.Next(10, 100);
            scores[i, 1] = random.Next(10, 100);
            scores[i, 2] = random.Next(10, 100);
        }

        return scores;
    }

    static double[,] CalculateTotalAveragePercentage(double[,] scores){
        int students = scores.GetLength(0);
        double[,] result = new double[students, 3];

        for (int i = 0; i < students; i++){
            double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3;
            double percentage = (total / 300) * 100;

            result[i, 0] = Math.Round(total, 2);
            result[i, 1] = Math.Round(average, 2);
            result[i, 2] = Math.Round(percentage, 2);
        }

        return result;
    }

    static void DisplayScoreCard(double[,] scores, double[,] results){
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");

        for (int i = 0; i < scores.GetLength(0); i++){
            Console.WriteLine((i + 1) + "\t" +scores[i, 0] + "\t" +scores[i, 1] + "\t\t" +
            scores[i, 2] + "\t" +results[i, 0] + "\t" +results[i, 1] + "\t" +results[i, 2]);
        }
    }
}
