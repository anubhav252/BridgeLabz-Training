using System;

class SearchComparison
{
    static int LinearSearch(int[] data, int target)
    {
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == target)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] data, int target)
    {
        int left = 0;
        int right = data.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (data[mid] == target)
                return mid;
            else if (data[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        int size = 10000000;
        int[] dataset = new int[size];

        for (int i = 0; i < size; i++)
            dataset[i] = i + 1;

        int target = size;

        DateTime startTime, endTime;

        startTime = DateTime.Now;
        LinearSearch(dataset, target);
        endTime = DateTime.Now;
        Console.WriteLine("Linear Search Time: " + (endTime - startTime).TotalMilliseconds + " ms");

        Array.Sort(dataset);

        startTime = DateTime.Now;
        BinarySearch(dataset, target);
        endTime = DateTime.Now;
        Console.WriteLine("Binary Search Time: " + (endTime - startTime).TotalMilliseconds + " ms");
    }
}
