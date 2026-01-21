using System;
namespace EduResults
{
    class EduResultsMain
    {
        static void Main(string[] args)
        {
            double[] district1={10,24,35,65,75};
            double[] district2={20,24,65,67,70,75};
            double[] district3={24,28,54,65};
            List<Double> mergedList=new List<Double>();
            mergedList.AddRange(district1);
            mergedList.AddRange(district2);
            mergedList.AddRange(district3);

            double[] mergedArray=mergedList.ToArray();
            MergeSort(mergedArray);
            DisplaySortedArray(mergedArray);
        }
        static void MergeSort(double[] mergedArray)
        {
            if (mergedArray.Length <= 1)
            {
                return;
            }
            int mid=mergedArray.Length/2;
            double[] left=new double[mid];
            double[]  right=new double[mergedArray.Length-mid];
            Array.Copy(mergedArray,0,left,0,mid);
            Array.Copy(mergedArray,mid,right,0,mergedArray.Length-mid);
            MergeSort(right);
            MergeSort(left);
            Merge(mergedArray,left,right);
        }
        static void Merge(double[] mergedArray,double[] left,double[] right)
        {
            int i=0,j=0,k=0;
            while(i<left.Length && j < right.Length)
            {
                if (left[i] > right[j])
                {
                    mergedArray[k++]=left[i++];
                }
                else
                {
                    mergedArray[k++]=right[j++];
                }
            }
            while (i < left.Length)
            {
                mergedArray[k++]=left[i++];
            }
            while (j < right.Length)
            {
                mergedArray[k++]=right[j++];
            }
        }
        static void DisplaySortedArray(double[] mergedArray)
        {
            foreach(double i in mergedArray)
            {
                System.Console.Write(i+" ");
            }
        }
    }
}