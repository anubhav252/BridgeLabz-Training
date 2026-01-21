using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = 6;

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");

        Console.WriteLine("Binary Numbers:");
        for (int i = 0; i < N; i++)
        {
            string current = queue.Dequeue();
            Console.Write(current + " ");

            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
    }
}
