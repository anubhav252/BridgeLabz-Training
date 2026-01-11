using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    internal class SelectionSort
    {
        static void SortScores(int[] scores)
        {
            int n = scores.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = scores[minIndex];
                scores[minIndex] = scores[i];
                scores[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[] scores = new int[n];

            Console.WriteLine("Enter exam scores:");
            for (int i = 0; i < n; i++)
            {
                scores[i] = int.Parse(Console.ReadLine());
            }

            SortScores(scores);

            Console.WriteLine("Sorted exam scores:");
            foreach (int score in scores)
            {
                Console.Write(score + " ");
            }
        }
    }
}
