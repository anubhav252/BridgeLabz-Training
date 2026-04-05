using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> symmetricDifference = new HashSet<int>();
        foreach (int item in set1)
        {
            if (!set2.Contains(item))
            {
                symmetricDifference.Add(item);
            }
        }
        foreach (int item in set2)
        {
            if (!set1.Contains(item))
            {
                symmetricDifference.Add(item);
            }
        }

        Console.WriteLine("Symmetric Difference:");

        foreach (int item in symmetricDifference)
        {
            Console.Write(item + " ");
        }
    }
}
