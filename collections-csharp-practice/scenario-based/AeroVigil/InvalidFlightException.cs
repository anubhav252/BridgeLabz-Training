using System;
class InvalidFlightException:Exception
{
    public InvalidFlightException(string message) : base(message){}
}