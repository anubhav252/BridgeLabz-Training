using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
class FlightUtil
{
    public bool ValidateFlightNumber(String flightNumber)
    {
        
        string pattern=@"(^[A-Z]{2})-([1-9]{1}[0-9]{3})$";
        if (Regex.IsMatch(flightNumber, pattern))
        {
            return true;
        }
        else
        {
            throw new InvalidFlightException($"The flight number {flightNumber} is invalid");
        }        
    }
    public bool ValidateFlightName(string flightName)
    {
        string pattern=@"^(SpiceJet)|(Vistara)|(IndiGo)|(Air Arabia)$";
        if (Regex.IsMatch(flightName, pattern))
        {
            return true;
        }
        else
        {
            throw new InvalidFlightException($"the flight name {flightName} is invalid");
        }
    }
    public bool ValidatePassengerCount(int passengerCount,string flightName)
    {
        Dictionary<string,int> flightData=new Dictionary<string, int>()
        {{"SpiceJet",396},{"Vistara",615},{"IndiGo",230},{"Air Arabia",130}};
        foreach(var flight in flightData)
        {
            if (flightName == flight.Key && (passengerCount < flight.Value && passengerCount > 0)){
                return true;
            }
        }
        throw new InvalidFlightException($"The passenger count {passengerCount} is invalid for {flightName}");
    }

    public double CalculateFuelToFillTank(string flightName,double currentFuelLevel)
    {
        Dictionary<string,double> flightFuelData=new Dictionary<string, double>()
        {{"SpiceJet",200000},{"Vistara",300000},{"IndiGo",250000},{"Air Arabia",150000}};
        foreach(var flightFuel in flightFuelData)
        {
            if(flightName == flightFuel.Key && (currentFuelLevel > flightFuel.Value || currentFuelLevel <0))
            {
               throw new InvalidFlightException($"Invalid Fuel Level for {flightName}"); 
            }
        }
        return (flightFuelData[flightName]-currentFuelLevel);

    }
}