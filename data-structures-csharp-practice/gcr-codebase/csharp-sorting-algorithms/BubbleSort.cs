using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    internal class BubbleSort
    {
        public void SortMarks(double[] marks)
        {
            for(int i = 0; i < marks.Length-1; i++)
            {
                for (int j = i + 1; j < marks.Length; j++) {
                    if (marks[i] > marks[j])
                    {
                        double temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                    }
                }
                
            }
            for(int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i]+" ");
            }  
        } 
        static void Main(string[] args)
        {
            BubbleSort sort = new BubbleSort();
            Console.WriteLine("Enter no. of students");
            int numberOfStudent=int.Parse(Console.ReadLine());
            double[] marks = new double[numberOfStudent];
            Console.WriteLine("Enter marks of students");
            for(int i = 0; i<marks.Length; i++)
            {
                marks[i]=double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            sort.SortMarks(marks);
        }
    }

}
