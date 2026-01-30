using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
class LexicalTwistUtility
{
    static LexicalTwistUtility obj=new LexicalTwistUtility();
    public void CheckReversed(string word1,string word2)
    {
        bool isReversed=true;
        if (word1.Length == word2.Length)
        {
            int j=word2.Length-1;
            for(int i = 0; i < word1.Length; i++)
            {
                if (!(word1[i].ToString().Equals(word2[j].ToString(),StringComparison.OrdinalIgnoreCase)))
                {
                    isReversed=false;
                    break;
                }
                j--;
            }
            if (isReversed)
            {
                obj.OpForReversed(word1);
                return;
            }
            else
            {
                obj.OpForNotReversed(word1,word2);
                return;
            }
        }
        else
        {
            obj.OpForNotReversed(word1,word2);
        }
    }
    public void OpForReversed(string word1)
    {
        string reversedWord1="";
        for(int i = word1.Length - 1; i >= 0; i--)
        {
            reversedWord1+=word1[i];
        }
        reversedWord1=reversedWord1.ToLower();
        string vowels=@"[aeiou]";
        string replace="@";
        string tranformedWord=Regex.Replace(reversedWord1,vowels,replace);
        System.Console.WriteLine(tranformedWord);
    }
    public void OpForNotReversed(string word1,string word2)
    {
        string mergedWord=word1+word2;
        String vowelInWord="";
        String consonentInWord="";
        mergedWord=mergedWord.ToUpper();
        int vCount=0,cCount=0;
        string vowels="AEIOU";
        for(int i = 0; i < mergedWord.Length; i++)
        {
            if (vowels.Contains(mergedWord[i]))
            {
                vCount++;
                if (!vowelInWord.Contains(mergedWord[i]))
                {
                    vowelInWord+=mergedWord[i];
                }
            }
            else
            {
                cCount++;
                if (!consonentInWord.Contains(mergedWord[i]))
                {
                    consonentInWord+=mergedWord[i];
                }
            }
        }
        if (vCount > cCount)
        {
            System.Console.WriteLine(vowelInWord.Substring(0,2));
        }
        else if (cCount > vCount)
        {
            System.Console.WriteLine(consonentInWord.Substring(0,2));
        }
        else
        {
            System.Console.WriteLine("Vowels and Consonents are equal");
        }
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first word");
        string word1=Console.ReadLine();
        if(word1.Contains(' '))
        {
            Console.Write($"{word1} is an inavlid word");
            return;
        }
        System.Console.WriteLine("Enter the second word");
        string word2=Console.ReadLine();
        if(word2.Contains(' '))
        {
            Console.Write($"{word2} is an inavlid word");
            return;
        }
        obj.CheckReversed(word1,word2);
    }
}