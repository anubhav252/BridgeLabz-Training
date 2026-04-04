using System;
public class LongestPrefix {

    public static string LongPrefix(string[] str) {
        if (str == null || str.Length == 0) {
            return "";
        }
        string prefix = str[0];
        for (int i = 1; i < str.Length; i++) {
            while (str[i].IndexOf(prefix) != 0) {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix.Length==0) {
                    return "";
                }
            }
        }

        return prefix;
    }

    public static void Main(string[] args) {
       
        int n = Convert.ToInt32(Console.ReadLine());
        
        string[] str = new string[n];
        for (int i = 0; i < n; i++) {
            str[i] = Console.ReadLine();
        }
        string res = LongPrefix(str);
        Console.WriteLine(res);

        
    }
}
