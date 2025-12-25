//REMOVE ELEMENT

/*Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
Return k.
*/

using System;
class RemoveElement{
    static int RemoveElementFromArray(int[] arr, int value){
        int k = 0;

        for (int i = 0; i < arr.Length; i++){
            if (arr[i] != value){
                arr[k] = arr[i];
                k++;
            }
        }

        return k;
    }

    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }

        int v = int.Parse(Console.ReadLine());

        int k = RemoveElementFromArray(arr, v);

        Console.WriteLine(k);

        for (int i = 0; i < k; i++){
            Console.Write(arr[i] + " ");
        }
    }
}
