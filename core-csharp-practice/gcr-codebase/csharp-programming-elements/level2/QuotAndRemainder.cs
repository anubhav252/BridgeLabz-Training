using System;

class QuotAndRemainder
{
    static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int quot = num1/num2;
        int remainder = num1%num2;

        Console.WriteLine("The Quotient is "+ quot+ " and Remainder is " + remainder +
		" of two numbers " + num1 + " and " +num2);
    }
}
