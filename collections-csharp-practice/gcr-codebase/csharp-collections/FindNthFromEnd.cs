using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void FindNthFromEnd(LinkedList<string> list, int n)
    {
        if (list == null || n <= 0)
            System.Console.WriteLine("Invalid input");

        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;
        for (int i = 0; i < n; i++)
        {
            if (first == null)
                System.Console.WriteLine("N is larger than list size");

            first = first.Next;
        }
        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }
        System.Console.WriteLine(second.Value);
    }

    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>();

        list.AddLast("A");
        list.AddLast("B");
        list.AddLast("C");
        list.AddLast("D");
        list.AddLast("E");
        int n = 2;
        FindNthFromEnd(list, n);
    }
}
