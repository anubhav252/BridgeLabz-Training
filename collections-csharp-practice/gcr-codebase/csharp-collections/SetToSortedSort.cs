using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };
        List<int> list = new List<int>();

        foreach (int item in set)
        {
            list.Add(item);
        }
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Sorted List:");
        foreach (int n in list)
        {
            Console.Write(n + " ");
        }
    }
}
