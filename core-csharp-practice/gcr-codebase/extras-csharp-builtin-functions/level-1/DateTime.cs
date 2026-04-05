using System;
class DateTime{
    static void Main(string[] args){
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        TimeZoneInfo gmt = TimeZoneInfo.Utc;
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        
		DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, ist);
		
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime, gmt);
        
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pst);

        Console.WriteLine("Time in Different Time Zones:");
		
		Console.WriteLine("IST : " + istTime);
		
        Console.WriteLine("GMT : " + gmtTime);
        
        Console.WriteLine("PST : " + pstTime);
    }
}
