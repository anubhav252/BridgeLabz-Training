using System;
class DateArithmetic{
    static void Main(string[] args){
        DateTime date = DateTime.Parse(Console.ReadLine());

        DateTime newDate = date
                                .AddDays(7)
                                .AddMonths(1)
                                .AddYears(2);

        newDate = newDate.AddDays(-21);

        Console.WriteLine(newDate.ToShortDateString());
    }
}
