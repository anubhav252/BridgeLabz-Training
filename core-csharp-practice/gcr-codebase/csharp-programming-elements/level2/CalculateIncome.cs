using System;

class CalcuateIncome{
    static void Main(string[] args){
        int salary = Convert.ToInt32(Console.ReadLine());
        int bonus = Convert.ToInt32(Console.ReadLine());
        int total = salary+bonus;

        Console.WriteLine("The salary is INR " +salary+ " and bonus is INR "+bonus + ". Hence Total Income is INR " +total);
    }
}
