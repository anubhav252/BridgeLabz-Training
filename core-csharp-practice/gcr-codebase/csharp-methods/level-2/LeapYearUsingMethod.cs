using System;
class LeapYearUsingMethod{
    static void Main(string[] args){
        int year = int.Parse(Console.ReadLine());

        bool isLeap = Checker(year);

        if (isLeap)
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("not a Leap Year");
    }

    public static bool Checker(int year){
        if (year < 1582){
            return false;
		}
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
            return true;
		}
        return false;
    }
}
