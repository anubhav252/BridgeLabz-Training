using System;
using System.Collections.Generic;
public class LongestSubstring {

    public static int LenOfSubstring(string s) {
        HashSet<char> hs = new HashSet<char>();

        int left = 0;
        int maxLen = 0;

        for (int right = 0; right < s.Length; right++) {
            char Ch = s[right];

            
            while (hs.Contains(Ch)) {
                hs.Remove(s[left]);
                left++;
            }

            hs.Add(Ch);
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }

    public static void Main(string[] args) {
       
        string s =Console.ReadLine();

        
        int res = LenOfSubstring(s);
        Console.WriteLine(res);
    }
}
