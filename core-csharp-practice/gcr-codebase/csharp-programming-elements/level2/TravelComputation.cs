using System;

class TravelComputation {
    static void Main(string[] args) {

      // take input for variable 'name' to indicate the person traveling
	   string name = Console.ReadLine();
      
      //take input of variables 'fromCity', 'viaCity', and 'toCity' for the cities
      string fromCity = Console.ReadLine();
	  string viaCity = Console.ReadLine();
	  string toCity = Console.ReadLine();

      // variables for distances and times
      double distanceFromToVia = Convert.ToDouble(Console.ReadLine());
      float timeFromToVia = float.Parse(Console.ReadLine());
      double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());
      float timeViaToFinalCity = float.Parse(Console.ReadLine());

      // Compute the total distance and total time
      double totalDistance = distanceFromToVia + distanceViaToFinalCity;
      float totalTime = timeFromToVia + timeViaToFinalCity;

      // output
      Console.WriteLine("The results of the trip are: totalDistance "+totalDistance+", totalTime "+ totalTime+ "hr" );
   }
}

