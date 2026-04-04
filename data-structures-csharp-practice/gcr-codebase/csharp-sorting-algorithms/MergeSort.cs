using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    internal class MergeSort
    {
        static void SortPrices(int[] prices, int left, int right)
        {
            if (left >= right)
                return;

            int mid = left + (right - left) / 2;

            SortPrices(prices, left, mid);
            SortPrices(prices, mid + 1, right);
            Merge(prices, left, mid, right);
        }

        static void Merge(int[] prices, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = prices[left + i];

            for (int j = 0; j < n2; j++)
                rightArray[j] = prices[mid + 1 + j];

            int iIndex = 0;
            int jIndex = 0;
            int k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    prices[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    prices[k] = rightArray[jIndex];
                    jIndex++;
                }
                k++;
            }

            while (iIndex < n1)
            {
                prices[k] = leftArray[iIndex];
                iIndex++;
                k++;
            }

            while (jIndex < n2)
            {
                prices[k] = rightArray[jIndex];
                jIndex++;
                k++;
            }
        }

        static void Main(string[] args)
        {
            int[] bookPrices = { 450, 120, 899, 300, 150, 700 };

            SortPrices(bookPrices, 0, bookPrices.Length - 1);

            foreach (int price in bookPrices)
            {
                Console.Write(price + " ");
            }
        }
    }
}
