using System;

class SpringSeasonUsingMethod{
    static void Main(string[] args){
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        bool spring = IsSpring(month, day);

        if (spring)
            Console.WriteLine("Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }
    static bool IsSpring(int month, int day){
        if ((month == 3 && day >= 20) || (month == 4) ||(month == 5) ||(month == 6 && day <= 20)) {
            return true;
        }
        return false;
    }
}
