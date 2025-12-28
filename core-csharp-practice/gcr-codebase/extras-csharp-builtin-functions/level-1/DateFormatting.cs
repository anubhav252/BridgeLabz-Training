using System;

class DateFormatting{
    static void Main(string[] args){
        DateTime current = DateTime.Now;

        Console.WriteLine("dd/MM/yyyy      : " + current.ToString("dd/MM/yyyy"));
        Console.WriteLine("yyyy-MM-dd      : " + current.ToString("yyyy-MM-dd"));
        Console.WriteLine("EEE, MMM dd, yyyy : " + current.ToString("ddd, MMM dd, yyyy"));
    }
}
