using System;
using System.Collections.Generic;

class RotateList
{
    static List<int> RotateLeft(List<int> list, int k)
    {
        int n = list.Count;
        k = k % n;   

        List<int> result = new List<int>();
        for (int i = k; i < n; i++)
        {
            result.Add(list[i]);
        }
        for (int i = 0; i < k; i++)
        {
            result.Add(list[i]);
        }

        return result;
    }

    static void Main()
    {
        List<int> list = new List<int> { 10, 20, 30, 40, 50 };

        List<int> rotated = RotateLeft(list, 2);

        foreach (int num in rotated)
        {
            Console.Write(num + " ");
        }
    }
}
