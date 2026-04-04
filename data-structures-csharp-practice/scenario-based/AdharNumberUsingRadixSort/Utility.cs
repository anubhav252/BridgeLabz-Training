using System;
using System.Globalization;
namespace AdharNoRadixSort
{
    class Utility:IOperations
    {
        private long[] arr=new long[10];
        private int n=0;
        public void AddAdharNumber()
        {
            if (n == 10)
            {
                Console.WriteLine("Array is Full");
                return;
            }
            Console.WriteLine("Enter Adhar Numbers:");
            arr[n]=long.Parse(Console.ReadLine());
            n++;   
        }
        // method for displaying sorted adhar numbers
        public void DisplaySortedAdharNumbers()
        {
            if (n == 0)
            {
                Console.WriteLine("No Adhar Numbers to Display");
                return;
            }
            RadixSort();
            Console.WriteLine("Sorted Adhar Numbers:");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        // sorting adhar number using radix sort
        public void RadixSort()
        {
            if (n == 0)
            {
                Console.WriteLine("No Adhar Numbers to Sort");
                return;
            }
            long max=GetMax();
            for(long place = 1; max / place > 0; place=place*10)
            {
                CountSort(place);
            }
        }

        public void CountSort(long place)
        {
            long[] output=new long[n];
            long[] count=new long[10];
            for(int i=0;i<10;i++)
            {
                count[i]=0;
            }
            for(int i = 0; i < n; i++)
            {
                int index=(int)((arr[i]/place)%10);
                count[index]++;
            }
            for(int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }
            for(int i = n - 1; i >= 0; i--)
            {
                int index=(int)((arr[i]/place)%10);
                output[count[index]-1]=arr[i];
                count[index]--;
            }
            Array.Copy(output,arr,n);
        }
        public long GetMax()
        {
            long maxNumber=0;
            foreach(long number in arr)
            {
                if(number > maxNumber)
                {
                    maxNumber=number;
                }
            }
            return maxNumber;
        }
        // searching adhar number using binary search
        public void SearchNumber()
        {
            if (n == 0)
            {
                Console.WriteLine("No Adhar Numbers to Search");
                return;
            }
            RadixSort();
            Console.WriteLine("Enter Adhar Number to Search:");
            long key=long.Parse(Console.ReadLine());
            int low=0;
            int high=n-1;

            while (low <= high)
            {
                int mid=(low+high)/2;
                if (arr[mid] == key)
                {
                    Console.WriteLine("Adhar Number Found at Position: " + (mid + 1));
                    return;
                }
                else if (arr[mid] < key)
                {
                    low=mid+1;
                }
                else
                {
                    high=mid-1;
                }
            }
        }
    }
} 