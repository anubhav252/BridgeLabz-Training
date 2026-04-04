using System;
using System.Text;

class ConcatenateString
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];

        for (int i = 0; i < n; i++)
            arr[i] = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
            sb.Append(arr[i]);

        Console.WriteLine(sb);
    }
}
