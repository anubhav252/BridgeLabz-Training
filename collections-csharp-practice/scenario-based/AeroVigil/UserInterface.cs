using System;
using System.Text.RegularExpressions;
class UserInterface
{
    static bool result1,result2,result3;
    static double result4;
    static void Main(string[] args)
    {
        FlightUtil utility=new FlightUtil();
        System.Console.WriteLine("Enter Flight Details---\nFormat should be-- \nFlightNumber:FlightName:PassengerCount:CurrentFuelLevel");
        string input=Console.ReadLine();
        string pattern=@"[:]";
        string[] splittedFields=Regex.Split(input,pattern);
        try
        {
            result1=utility.ValidateFlightNumber(splittedFields[0]);
            if (result1)
            {
                result2=utility.ValidateFlightName(splittedFields[1]);
            }
            if (result2)
            {
                result3=utility.ValidatePassengerCount(Convert.ToInt32(splittedFields[2]),splittedFields[1]);
            }
            if (result3)
            {
                result4=utility.CalculateFuelToFillTank(splittedFields[1],Convert.ToDouble(splittedFields[3]));
                System.Console.WriteLine($"Fuel required to fill the tank : {result4} liters");
            }  
        }
        catch(InvalidFlightException e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}