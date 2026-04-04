using System;
using System.Text;

class CompareStringBuilder
{
    static void Main()
    {
        int n = 50000;

        string s = "";
        DateTime t1 = DateTime.Now;

        for (int i = 0; i < n; i++)
            s = s + "a";

        DateTime t2 = DateTime.Now;

        StringBuilder sb = new StringBuilder();
        DateTime t3 = DateTime.Now;

        for (int i = 0; i < n; i++)
            sb.Append("a");

        DateTime t4 = DateTime.Now;

        Console.WriteLine((t2 - t1).Milliseconds);
        Console.WriteLine((t4 - t3).Milliseconds);
    }
}
