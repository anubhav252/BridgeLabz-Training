using System;

class MissingPositive
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int target = int.Parse(Console.ReadLine());

        bool[] present = new bool[n + 1];

        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0 && arr[i] <= n)
                present[arr[i]] = true;
        }

        int missing = 1;
        for (int i = 1; i <= n; i++)
        {
            if (!present[i])
            {
                missing = i;
                break;
            }
        }

        Array.Sort(arr);

        int low = 0, high = n - 1, index = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                index = mid;
                break;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        Console.WriteLine(missing);
        Console.WriteLine(arr[index]);
    }
}
