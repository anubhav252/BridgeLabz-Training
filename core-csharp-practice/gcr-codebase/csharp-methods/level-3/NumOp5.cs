using System;
class NumOp5{
    static void Main(string[] args){
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Is Prime Number = " + IsPrime(number));
        Console.WriteLine("Is Neon Number = " + IsNeon(number));
        Console.WriteLine("Is Spy Number = " + IsSpy(number));
        Console.WriteLine("Is Automorphic Number = " + IsAutomorphic(number));
        Console.WriteLine("Is Buzz Number = " + IsBuzz(number));
    }

    static bool IsPrime(int number){
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++){
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static bool IsNeon(int number){
        int square = number * number;
        int sum = 0;

        while (square > 0){
            sum += square % 10;
            square /= 10;
        }

        return sum == number;
    }

    static bool IsSpy(int number){
        int sum = 0;
        int product = 1;
        int temp = Math.Abs(number);

        while (temp > 0){
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            temp /= 10;
        }

        return sum == product;
    }

    static bool IsAutomorphic(int number){
        int square = number * number;
        int temp = number;

        while (temp > 0){
            if (temp % 10 != square % 10)
                return false;

            temp /= 10;
            square /= 10;
        }

        return true;
    }

    static bool IsBuzz(int number){
        return number % 7 == 0 || number % 10 == 7;
    }
}
