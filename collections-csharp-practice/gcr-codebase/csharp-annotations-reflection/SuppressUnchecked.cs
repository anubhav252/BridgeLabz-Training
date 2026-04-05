using System;
using System.Collections;

class Program
{
    static void Main()
    {
#pragma warning disable 618
#pragma warning disable 219

        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Hello");
        list.Add(25.5);

#pragma warning restore 618
#pragma warning restore 219

        Console.WriteLine("ArrayList contents:");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
