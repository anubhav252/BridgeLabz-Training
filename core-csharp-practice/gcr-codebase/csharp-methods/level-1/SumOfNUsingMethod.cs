using System;

class SumOfNUsingMethod{
    static void Main(string[] args){
        int num = int.Parse(Console.ReadLine());

        if (num <= 0){
            Console.WriteLine("Please enter a positive natural number.");
            return;
        }

        int ans = CalculateSum(num);
        Console.WriteLine("Sum of " + num + " natural numbers = " + ans);
    }
    public static int CalculateSum(int n){
        int sum = 0;
        for (int i = 1; i <= n; i++){
            sum += i;
        }
        return sum;
    }
}
