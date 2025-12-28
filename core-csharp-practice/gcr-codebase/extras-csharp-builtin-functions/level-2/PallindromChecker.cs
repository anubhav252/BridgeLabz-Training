using System;
class PalindromeChecker{
    static void Main(string[] args){
        string str = Console.ReadLine();
        bool result = IsPalindrome(str);
        DisplayResult(result);
    }

    static string GetInput(){
        return Console.ReadLine();
    }

    static bool IsPalindrome(string text){
        int left = 0;
        int right = text.Length - 1;

        while (left < right){
            if (text[left] != text[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    static void DisplayResult(bool isPalindrome){
        if (isPalindrome)
            Console.WriteLine("is a palindrome.");
        else
            Console.WriteLine("not a palindrome.");
    }
}
