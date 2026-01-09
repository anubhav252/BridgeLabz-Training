using System;
using System.Collections.Generic;

namespace LongestConsecutiveSequence
{
    class Program
    {
        static int FindLongest(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            HashSet<int> set = new HashSet<int>(nums);
            int longest = 0;

            foreach (int num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int current = num;
                    int length = 1;

                    while (set.Contains(current + 1))
                    {
                        current++;
                        length++;
                    }

                    if (length > longest)
                        longest = length;
                }
            }

            return longest;
        }

        static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };

            int result = FindLongest(nums);

            Console.WriteLine(result);
        }
    }
}
