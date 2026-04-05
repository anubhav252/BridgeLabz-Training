using System;
using System.Collections.Generic;

class Program
{
    static void ReverseQueue(Queue<int> queue)
    {
        if (queue.Count == 0)
            return;

        int front = queue.Dequeue();

        ReverseQueue(queue);
        queue.Enqueue(front);
    }

    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        ReverseQueue(queue);

        Console.WriteLine("Reversed Queue:");

        foreach (int item in queue)
        {
            Console.Write(item + " ");
        }
    }
}
