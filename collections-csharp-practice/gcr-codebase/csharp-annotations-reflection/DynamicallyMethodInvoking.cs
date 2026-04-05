using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();
        Type type = typeof(MathOperations);

        Console.WriteLine("Enter method name (Add / Subtract / Multiply):");
        string methodName = Console.ReadLine();

        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());

        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine("Invalid method name.");
            return;
        }

        object result = method.Invoke(math, new object[] { a, b });

        Console.WriteLine("Result: " + result);
    }
}
