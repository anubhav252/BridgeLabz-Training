using System;
using System.Text;

class ConcatenationComparison
{
    static void Main()
    {
        int count = 10000;
        DateTime start, end;

       
        start = DateTime.Now;
        string result = "";
        for (int i = 0; i < count; i++)
        {
            result += "a";
        }
        end = DateTime.Now;
        Console.WriteLine("String Time: " + (end - start).TotalMilliseconds + " ms");

     
        start = DateTime.Now;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            sb.Append("a");
        }
        end = DateTime.Now;
        Console.WriteLine("StringBuilder Time: " + (end - start).TotalMilliseconds + " ms");
    }
}
