using System;
class NumOp6{
    static void Main(string[] args){
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("Factors:");
        for (int i = 0; i < factors.Length; i++){
            Console.WriteLine(factors[i]);
        }

        Console.WriteLine("Greatest Factor = " + FindGreatestFactor(factors));
        Console.WriteLine("Sum of Factors = " + FindSum(factors));
        Console.WriteLine("Product of Factors = " + FindProduct(factors));
        Console.WriteLine("Product of Cube of Factors = " + FindProductOfCubeOfFactors(factors));

        Console.WriteLine("Is Perfect Number = " + IsPerfectNumber(number, factors));
        Console.WriteLine("Is Abundant Number = " + IsAbundantNumber(number, factors));
        Console.WriteLine("Is Deficient Number = " + IsDeficientNumber(number, factors));
        Console.WriteLine("Is Strong Number = " + IsStrongNumber(number));
    }

    static int[] FindFactors(int number){
        int count = 0;
        for (int i = 1; i <= number; i++){
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++){
            if (number % i == 0)
                factors[index++] = i;
        }
        return factors;
    }
    static int FindGreatestFactor(int[] factors){
        int max = factors[0];

        for (int i = 1; i < factors.Length; i++)
        {
            if (factors[i] > max)
                max = factors[i];
        }

        return max;
    }
    static int FindSum(int[] factors){
        int sum = 0;

        for (int i = 0; i < factors.Length; i++){
            sum += factors[i];
        }

        return sum;
    }

    static long FindProduct(int[] factors){
        long product = 1;

        for (int i = 0; i < factors.Length; i++){
            product *= factors[i];
        }

        return product;
    }

    static double FindProductOfCubeOfFactors(int[] factors){
        double product = 1;

        for (int i = 0; i < factors.Length; i++){
            product *= Math.Pow(factors[i], 3);
        }

        return product;
    }

    static bool IsPerfectNumber(int number, int[] factors){
        int sum = 0;

        for (int i = 0; i < factors.Length - 1; i++){
            sum += factors[i];
        }

        return sum == number;
    }

    static bool IsAbundantNumber(int number, int[] factors){
        int sum = 0;

        for (int i = 0; i < factors.Length - 1; i++){
            sum += factors[i];
        }

        return sum > number;
    }

    static bool IsDeficientNumber(int number, int[] factors){
        int sum = 0;

        for (int i = 0; i < factors.Length - 1; i++){
            sum += factors[i];
        }

        return sum < number;
    }

    static bool IsStrongNumber(int number){
        int temp = number;
        int sum = 0;

        while (temp > 0){
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }

        return sum == number;
    }

    static int Factorial(int n){
        int fact = 1;

        for (int i = 1; i <= n; i++){
            fact *= i;
        }

        return fact;
    }
}
