using System;
using System.Collections.Generic;

class Program
{
    static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
    {
        if (set1.Count != set2.Count)
            return false;

        foreach (int item in set1)
        {
            if (!set2.Contains(item))
                return false;
        }

        return true;
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };

        Console.WriteLine(AreSetsEqual(set1, set2));
    }
}
