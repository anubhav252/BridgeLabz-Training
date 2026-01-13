using System;

class SearchTarget
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = int.Parse(Console.ReadLine());

        int target = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            int low = 0, high = cols - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (matrix[i, mid] == target)
                {
                    Console.WriteLine("Found at row " + i + ", column " + mid);
                    return;
                }
                else if (matrix[i, mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
        }

        Console.WriteLine("Not found");
    }
}
