using System;

public class StringUtils
{
    public string Reverse(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public bool IsPalindrome(string str)
    {
        string reversed = Reverse(str);
        return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str)
    {
        return str.ToUpper();
    }
}
