using System;
using System.Collections.Generic;

namespace PairWithGivenSum
{
    class Program
    {
        static bool HasPair(int[] arr, int target)
        {
            HashSet<int> visited = new HashSet<int>();

            foreach (int num in arr)
            {
                int required = target - num;

                if (visited.Contains(required))
                {
                    return true;
                }

                visited.Add(num);
            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] num = { 8, 7, 2, 5, 3, 1 };
            int target = 10;

            bool result = HasPair(num, target);

            Console.WriteLine(result);
        }
    }
}
