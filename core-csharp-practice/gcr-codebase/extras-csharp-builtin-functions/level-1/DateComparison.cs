using System;
class DateComparison{
    static void Main(string[] args){
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        int result = DateTime.Compare(date1, date2);

        if (result < 0){
            Console.WriteLine("first date is before the second date.");
        }
        else if (result > 0){
            Console.WriteLine("first date is after the second date.");
        }
        else{
            Console.WriteLine("Both dates are the same.");
        }
    }
}
