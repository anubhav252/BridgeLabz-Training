//Two Sum
/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
*/
using System;
class TwoSum{
	static void Main(string[] args){
		int size=int.Parse(Console.ReadLine());
		int target=int.Parse(Console.ReadLine());
		int[] nums=new int[size];
		for(int i=0;i<size;i++){
			nums[i]=int.Parse(Console.ReadLine());
		}
		int[] ans=Sum(nums,target);
		
		for(int i=0;i<2;i++){
			Console.Write(ans[i] + " ");
			
		}
		
	}
	public static int[] Sum(int[] nums,int target){
		int[] result=new int[2];
		for(int i=0;i<nums.Length;i++){
			for(int j=i+1;j<nums.Length;j++){
				if(nums[i]+nums[j]==target){
					result[0]=i;
					result[1]=j;
				}
			}
		}
		return result;
	}
}