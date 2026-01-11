/*Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3
*/

using System;
class MajorityElement{
	static int GetElement(int[] arr){
		int count = 0;
        int candidate = 0;

        foreach (int num in arr) {
            if (count == 0) {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }
        return candidate;
	}
	
	static void Main(string[] args){
		
		int num=int.Parse(Console.ReadLine());
		int[] arr=new int[num];
		for(int i=0;i<arr.Length;i++){
			arr[i]=int.Parse(Console.ReadLine());
		}
		int result=GetElement(arr);
		Console.WriteLine("result"+result);
	}
}
	