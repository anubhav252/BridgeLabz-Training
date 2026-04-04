using System;
using System.Collections.Generic;

namespace TwoSumProblem
{
    class Program
    {
        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int required = target - nums[i];

                if (map.ContainsKey(required))
                {
                    return new int[] { map[required], i };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }

            return new int[] { -1, -1 };
        }

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);

            if (result[0] != -1)
            {
                Console.WriteLine("Indices: " + result[0] + ", " + result[1]);
            }
            else
            {
                Console.WriteLine("No valid pair found");
            }
        }
    }
}
