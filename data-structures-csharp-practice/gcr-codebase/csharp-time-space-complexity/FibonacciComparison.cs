using System;

class FibonacciComparison
{
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    public static int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, sum = 0;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }

        return b;
    }

    static void Main()
    {
        int n = 35;

        DateTime start, end;

        start = DateTime.Now;
        int recursiveResult = FibonacciRecursive(n);
        end = DateTime.Now;
        Console.WriteLine("Recursive Fibonacci Result: " + recursiveResult);
        Console.WriteLine("Recursive Time: " + (end - start).TotalMilliseconds + " ms");

        start = DateTime.Now;
        int iterativeResult = FibonacciIterative(n);
        end = DateTime.Now;
        Console.WriteLine("Iterative Fibonacci Result: " + iterativeResult);
        Console.WriteLine("Iterative Time: " + (end - start).TotalMilliseconds + " ms");
    }
}
