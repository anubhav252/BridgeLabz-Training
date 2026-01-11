using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    internal class InsertionSort
    {
        public void SortId(int[] Ids) { 
            for(int i = 1; i < Ids.Length; i++)
            {
                int key = Ids[i];
                int j = i - 1;
                while(j>=0 && Ids[j] > key)
                {
                    Ids[j + 1] = Ids[j];
                    j--;
                }
                Ids[j + 1] = key;
            }
            for(int i = 0;i < Ids.Length; i++)
            {
                Console.Write(Ids[i]+" ");
            }

        }

        static void Main(string[] args)
        {
            InsertionSort sort = new InsertionSort();

            Console.WriteLine("enter no. of employees");
            int num = int.Parse(Console.ReadLine());
            int[] Ids = new int[num];
            Console.WriteLine("enter ids of employees");
            for (int i = 0; i < num; i++)
            {
                Ids[i] = int.Parse(Console.ReadLine());
            }
            sort.SortId(Ids);   
            
        }

    }
}
