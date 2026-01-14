using System;

class SortingComparison
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right)
            return;

        int mid = (left + right) / 2;

        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
            arr[k++] = (L[i] <= R[j]) ? L[i++] : R[j++];

        while (i < n1)
            arr[k++] = L[i++];

        while (j < n2)
            arr[k++] = R[j++];
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(arr, low, high);
            QuickSort(arr, low, pivot - 1);
            QuickSort(arr, pivot + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int swap = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swap;

        return i + 1;
    }

    static void Main()
    {
        int size = 20000;
        int[] data = new int[size];

        Random rand = new Random();
        for (int i = 0; i < size; i++)
            data[i] = rand.Next(1, size);

        DateTime start, end;

        int[] bubbleData = (int[])data.Clone();
        start = DateTime.Now;
        BubbleSort(bubbleData);
        end = DateTime.Now;
        Console.WriteLine("Bubble Sort Time: " + (end - start).TotalMilliseconds + " ms");

        int[] mergeData = (int[])data.Clone();
        start = DateTime.Now;
        MergeSort(mergeData, 0, mergeData.Length - 1);
        end = DateTime.Now;
        Console.WriteLine("Merge Sort Time: " + (end - start).TotalMilliseconds + " ms");

        int[] quickData = (int[])data.Clone();
        start = DateTime.Now;
        QuickSort(quickData, 0, quickData.Length - 1);
        end = DateTime.Now;
        Console.WriteLine("Quick Sort Time: " + (end - start).TotalMilliseconds + " ms");
    }
}
