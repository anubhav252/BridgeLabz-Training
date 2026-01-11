using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    internal class HeapSort
    {
        static void SortSalary(int[] salaries)
        {
            int n = salaries.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(salaries, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                int temp = salaries[0];
                salaries[0] = salaries[i];
                salaries[i] = temp;

                Heapify(salaries, i, 0);
            }
        }

        static void Heapify(int[] salaries, int heapSize, int root)
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < heapSize && salaries[left] > salaries[largest])
                largest = left;

            if (right < heapSize && salaries[right] > salaries[largest])
                largest = right;

            if (largest != root)
            {
                int temp = salaries[root];
                salaries[root] = salaries[largest];
                salaries[largest] = temp;

                Heapify(salaries, heapSize, largest);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of applicants: ");
            int n = int.Parse(Console.ReadLine());

            int[] salaries = new int[n];

            Console.WriteLine("Enter salary :");
            for (int i = 0; i < n; i++)
            {
                salaries[i] = int.Parse(Console.ReadLine());
            }

            SortSalary(salaries);

            Console.WriteLine("Sorted salary :");
            foreach (int salary in salaries)
            {
                Console.Write(salary + " ");
            }
        }

    }
}
