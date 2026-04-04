using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
            sb.Append(input[i]);

        Console.WriteLine(sb);
    }
}
