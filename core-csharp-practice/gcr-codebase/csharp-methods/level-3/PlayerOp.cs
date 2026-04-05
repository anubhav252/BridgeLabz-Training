using System;
class PlayerOp{
    static void Main(string[] args){
        int[] heights = new int[11];
        Random random = new Random();

        for (int i = 0; i < heights.Length; i++){
            heights[i] = random.Next(150, 251);
        }

        int sum = FindSum(heights);
        double mean = FindMean(heights);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine("Player Heights:");
        for (int i = 0; i < heights.Length; i++){
            Console.WriteLine(heights[i]);
        }
        Console.WriteLine("Shortest Height = " + shortest);
        Console.WriteLine("Tallest Height = " + tallest);
        Console.WriteLine("Mean Height = " + mean);
    }

    static int FindSum(int[] heights){
        int sum = 0;

        for (int i = 0; i < heights.Length; i++){
            sum += heights[i];
        }

        return sum;
    }

    static double FindMean(int[] heights){
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    static int FindShortest(int[] heights){
        int min = heights[0];

        for (int i = 1; i < heights.Length; i++){
            if (heights[i] < min)
                min = heights[i];
        }

        return min;
    }

    static int FindTallest(int[] heights){
        int max = heights[0];

        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > max)
                max = heights[i];
        }

        return max;
    }
}
