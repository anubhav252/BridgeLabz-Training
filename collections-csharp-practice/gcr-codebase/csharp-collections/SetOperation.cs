using System;
using System.Collections.Generic;

class SetOperations
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> union = new HashSet<int>();
        HashSet<int> intersection = new HashSet<int>();
        foreach (int item in set1)
        {
            union.Add(item);
        }

        foreach (int item in set2)
        {
            if (!union.Contains(item))
            {
                union.Add(item);
            }
        }
        foreach (int item in set1)
        {
            if (set2.Contains(item))
            {
                intersection.Add(item);
            }
        }
        Console.WriteLine("Union:");
        foreach (int item in union)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nIntersection:");
        foreach (int item in intersection)
        {
            Console.Write(item + " ");
        }
    }
}
