// Longest Common Prefix

/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: str = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: str = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 */
 
using System;

class LongestCommonPrefix{
    static void Main(string[] args){
        int num = int.Parse(Console.ReadLine());
        string[] str = new string[num];
        for (int i = 0; i < num; i++){
            str[i] = Console.ReadLine();
        }

        string result = FindLongest(str);
        Console.WriteLine(result);
    }

    static string FindLongest(string[] str){
         string ans = str[0];
		if (str.Length == 0 || ans.Length==0){
            return "";
		}
       
        for (int i = 1; i < str.Length; i++){
            while (!str[i].StartsWith(ans)){
                if (ans.Length == 0){
                    return "";
				}
                ans = ans.Substring(0, ans.Length - 1);
            }
        }
        return ans;
    }
}
