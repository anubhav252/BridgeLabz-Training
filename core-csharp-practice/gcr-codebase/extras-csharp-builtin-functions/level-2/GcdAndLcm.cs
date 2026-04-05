using System;
class GcdAndLcm{
    static void Main(string[] args){
        int a = GetInput();
        int b = GetInput();

        int gcd = CalculateGCD(a, b);
        int lcm = CalculateLCM(a, b, gcd);

        DisplayResult(a, b, gcd, lcm);
    }

    static int GetInput(){
        return int.Parse(Console.ReadLine());
    }

    static int CalculateGCD(int a, int b){
        if (b == 0)
            return a;

        return CalculateGCD(b, a % b);
    }

    static int CalculateLCM(int a, int b, int gcd){
        return (a * b) / gcd;
    }

    static void DisplayResult(int a, int b, int gcd, int lcm){
        Console.WriteLine("GCD : "+ gcd);
        Console.WriteLine("LCM : "+lcm);
    }
}
