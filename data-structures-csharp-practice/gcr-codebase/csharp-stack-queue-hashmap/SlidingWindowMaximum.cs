using System;
using System.Collections.Generic;

namespace SlidingWindowMaximum
{
    class Program
    {
        static int[] FindMaximum(int[] nums, int k)
        {
            if (nums.Length == 0 || k <= 0)
                return new int[0];

            int n = nums.Length;
            int[] result = new int[n - k + 1];
            LinkedList<int> deque = new LinkedList<int>();

            for (int i = 0; i < n; i++)
            {
                if (deque.Count > 0 && deque.First.Value <= i - k)
                    deque.RemoveFirst();

                while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                    deque.RemoveLast();

                deque.AddLast(i);

                if (i >= k - 1)
                    result[i - k + 1] = nums[deque.First.Value];
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            int[] output = FindMaximum(nums, k);

            foreach (int value in output)
            {
                Console.Write(value + " ");
            }
        }
    }
}
