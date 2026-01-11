using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    internal class QuickSort
    {
        static void SortPrices(int[] prices, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(prices, low, high);
                SortPrices(prices, low, pivotIndex - 1);
                SortPrices(prices, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] prices, int low, int high)
        {
            int pivot = prices[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (prices[j] < pivot)
                {
                    i++;
                    Swap(prices, i, j);
                }
            }

            Swap(prices, i + 1, high);
            return i + 1;
        }

        static void Swap(int[] prices, int i, int j)
        {
            int temp = prices[i];
            prices[i] = prices[j];
            prices[j] = temp;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of products: ");
            int n = int.Parse(Console.ReadLine());

            int[] prices = new int[n];

            Console.WriteLine("Enter product prices:");
            for (int i = 0; i < n; i++)
            {
                prices[i] = int.Parse(Console.ReadLine());
            }

            SortPrices(prices, 0, n - 1);

            Console.WriteLine("Sorted product prices:");
            foreach (int price in prices)
            {
                Console.Write(price + " ");
            }
        }
    }
}
