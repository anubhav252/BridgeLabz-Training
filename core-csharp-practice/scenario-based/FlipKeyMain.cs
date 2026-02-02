using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
namespace Flipkey
{
    class FlipKeyMain
    {
        public string CleanseAndInvert(string input)
        {
            string pattern=@"^[a-zA-Z]+$";
            StringBuilder ans=new StringBuilder();
            if(input==null || input.Length < 6 || !Regex.IsMatch(input, pattern))
            {
                return "";
            }
            string inputToLower=input.ToLower();
            for(int i = inputToLower.Length-1; i >=0; i--)
            {
                if ((int)inputToLower[i] % 2 != 0)
                {
                    ans.Append(inputToLower[i]);
                }
            }
            StringBuilder finalAns=new StringBuilder();
            for(int i = 0; i < ans.Length; i++)
            {
                if (i % 2 == 0)
                {
                    char ch=char.ToUpper(ans[i]);
                    finalAns.Append(ch);
                }
                else
                {
                    finalAns.Append(ans[i]);
                }
            }
            return finalAns.ToString();
        }

        static void Main(string[] args)
        {
            FlipKeyMain obj=new FlipKeyMain();
            System.Console.WriteLine("Enter the word");
            string input=Console.ReadLine();
            string result= obj.CleanseAndInvert(input);
            if (result == "")
            {
                System.Console.WriteLine("Invalid Input");
                return;
            }
            System.Console.WriteLine("The generated key is - "+result);
        }
    }
}