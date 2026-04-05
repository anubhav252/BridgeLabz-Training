using System;
class SmallestUsingMethod{
    static void Main(string[] args){
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int[] result = FindSmallestAndLargest(num1, num2, num3);
        Console.WriteLine("Smallest = " + result[0]);
        Console.WriteLine("Largest = " + result[1]);
    }
    public static int[] FindSmallestAndLargest(int num1, int num2, int num3){
        int smallest = num1;
        int largest = num1;
        if (num2 < smallest)
            smallest = num2;

        if (num3 < smallest)
            smallest = num3;

        if (num2 > largest)
            largest = num2;

        if (num3 > largest)
            largest = num3;
        return new int[] {smallest,largest };
    }
}
