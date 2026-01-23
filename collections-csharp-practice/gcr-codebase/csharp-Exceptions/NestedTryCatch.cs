using System;

class NestedTryCatchDemo
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Enter array index: ");
            int index = int.Parse(Console.ReadLine());

            try
            {
                Console.Write("Enter divisor : ");
                int divisor = int.Parse(Console.ReadLine());

                int result = numbers[index] / divisor;
                Console.WriteLine("Result : " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}
