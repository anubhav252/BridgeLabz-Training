using System;
using System.Collections.Generic;

namespace ZeroSumSubarrays
{
    class Program
    {
        static void FindSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
            int cumulativeSum = 0;

            sumMap[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                cumulativeSum += arr[i];

                if (sumMap.ContainsKey(cumulativeSum))
                {
                    foreach (int startIndex in sumMap[cumulativeSum])
                    {
                        Console.WriteLine(
                            "Subarray found from index " +
                            (startIndex + 1) + " to " + i
                        );
                    }
                }

                if (!sumMap.ContainsKey(cumulativeSum))
                {
                    sumMap[cumulativeSum] = new List<int>();
                }

                sumMap[cumulativeSum].Add(i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7 };

            FindSubarrays(arr);
        }
    }
}
