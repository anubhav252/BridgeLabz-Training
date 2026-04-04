using System;

class QuotientUsingMethod{
    static void Main(string[] args){
        int num = int.Parse(Console.ReadLine());
        int divisor = int.Parse(Console.ReadLine());

        if (divisor == 0)
        {
            Console.WriteLine("invalid");
            return;
        }

        int[] result = FindRemainderAndQuotient(num,divisor);

        Console.WriteLine("Quotient = " + result[0]);
        Console.WriteLine("Remainder = " + result[1]);
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;

        return new int[] { quotient, remainder };
    }
}
