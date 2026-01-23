using System;
class PropagatingException
{
    static void Method1(int num)
    {
        if (num == 0)
        {
            throw new ArithmeticException();
        }
        System.Console.WriteLine(10/num); 
    }

    static void Method2()
    {
        System.Console.WriteLine("enter number to divide 10");
        int num=int.Parse(Console.ReadLine());
        Method1(num);
    }

    static void Main()
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main!");
        }
    }
}
