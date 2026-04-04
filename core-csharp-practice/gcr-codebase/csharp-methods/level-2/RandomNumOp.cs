using System;
class RandomNumOp{
    static void Main(string[] args){
        int size = 5;

        int[] num = GenRandom(size);
        double[] result = FindAvg(num);

        Console.WriteLine("Generated num:");
        for (int i = 0; i < num.Length; i++){
            Console.WriteLine(num[i]);
        }

        Console.WriteLine("Average = " + result[0]);
        Console.WriteLine("Minimum = " + result[1]);
        Console.WriteLine("Maximum = " + result[2]);
    }

    static int[] GenRandom(int size){
        int[] num = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++){
            num[i] = random.Next(1000, 10000); 
        }

        return num;
    }

    static double[] FindAvg(int[] num){
        int min = num[0];
        int max = num[0];
        int sum = 0;

        for (int i = 0; i < num.Length; i++){
            sum += num[i];
            min = Math.Min(min, num[i]);
            max = Math.Max(max, num[i]);
        }

        double average = (double)sum / num.Length;

        return new double[] { average, min, max };
    }
}
