//Search Insert Position
/*
Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
*/
using System;
class SearchInsertPosition{
	static void Main(string[] args){
		int size=int.Parse(Console.ReadLine());
		int[] nums=new int[size];
		for(int i=0;i<size;i++){
			nums[i]=int.Parse(Console.ReadLine());
		}
		int target=int.Parse(Console.ReadLine());
		int ans=FindPosition(nums,target);
		Console.WriteLine(ans);
	}
	public static int FindPosition(int[] nums,int target){
		int start = 0;
        int end = nums.Length-1;

        while (start <= end) {
            int mid = start + (end-start)/2;
            if (nums[mid] == target) return mid;
            else if (nums[mid] > target) end = mid-1;
            else start = mid+1;
        }
		return start;
	}
}