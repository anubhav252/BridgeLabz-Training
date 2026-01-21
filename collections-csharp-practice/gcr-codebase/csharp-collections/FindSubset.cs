using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> setA = new HashSet<int> { 2, 3 };
        HashSet<int> setB = new HashSet<int> { 1, 2, 3, 4 };

        bool isSubset = true;

        foreach (int item in setA)
        {
            if (!setB.Contains(item))
            {
                isSubset = false;
                break;
            }
        }
        Console.WriteLine(isSubset);
    }
}
