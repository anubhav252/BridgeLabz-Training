using System;

class YoungestOfThreeUsingMethod{
    static void Main(string[] args){
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        int[] heights = new int[3];
        for (int i = 0; i < 3; i++)
        {
            ages[i] = int.Parse(Console.ReadLine());
            heights[i] = int.Parse(Console.ReadLine());
        }

        int youngest = FindYoungest(ages);
        int tallest = FindTallest(heights);

        Console.WriteLine("Youngest  " + friends[youngest]);
        Console.WriteLine("Tallest  " + friends[tallest]);
    }

    static int FindYoungest(int[] ages){
        int min = 0;
        for (int i = 1; i < ages.Length; i++){
            if (ages[i] < ages[min]){
                min = i;
            }
        }
        return min;
    }

    static int FindTallest(int[] heights){
        int max = 0;
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > heights[max]){
                max = i;
            }
        }
        return max;
    }
}
