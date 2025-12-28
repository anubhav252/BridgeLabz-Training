using System;

class Factorial{
    static void Main(string[] args){
        int num = GetInput();
        long result = CalculateFactorial(num);
        DisplayResult(num, result);
    }

    static int GetInput(){
        return int.Parse(Console.ReadLine());
    }

    static long CalculateFactorial(int n){
        if (n <= 1)
            return 1;

        return n * CalculateFactorial(n - 1);
    }

    static void DisplayResult(int num, long factorial){
        Console.WriteLine(factorial);
    }
}
