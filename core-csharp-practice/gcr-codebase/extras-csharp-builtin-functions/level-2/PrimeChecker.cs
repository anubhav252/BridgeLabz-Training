using System;
class PrimeNumberChecker{
    static void Main(string[] args){
        int num = int.Parse(Console.ReadLine());

        bool isPrime = CheckPrime(num);

        if (isPrime){
            Console.WriteLine("is a prime num.");
        }
        else{
            Console.WriteLine("not a prime num.");
        }
    }

    static bool CheckPrime(int num){
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++){
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
