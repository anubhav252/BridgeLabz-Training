using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    internal class CountingSort
    {
        static void SortAge(int[] ages, int minAge, int maxAge)
        {
            int range = maxAge - minAge + 1;
            int[] count = new int[range];
            int[] output = new int[ages.Length];

            for (int i = 0; i < ages.Length; i++)
            {
                count[ages[i] - minAge]++;
            }

            for (int i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = ages.Length - 1; i >= 0; i--)
            {
                int index = ages[i] - minAge;
                output[count[index] - 1] = ages[i];
                count[index]--;
            }

            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = output[i];
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[] ages = new int[n];

            Console.WriteLine("Enter student ages :");
            for (int i = 0; i < n; i++)
            {
                ages[i] = int.Parse(Console.ReadLine());
            }

            SortAge(ages, 10, 18);

            Console.WriteLine("Sorted student ages:");
            foreach (int age in ages)
            {
                Console.Write(age + " ");
            }
        }
    }
}
