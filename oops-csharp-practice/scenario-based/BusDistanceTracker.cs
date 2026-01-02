using System;
class BusRoute{
	private static float[] Distance;
	
	public BusRoute(){
		Distance=new float[]{124.5f,200.0f,250.0f,130.7f};
	}
	
	public float StartJourney(){
		float totalDistance=0;
		while(true){
			Console.WriteLine("1. Start Journey");
			Console.WriteLine("2. Get Total Distance and Exit");
			int choice=int.Parse(Console.ReadLine());
			
			switch (choice){
				case 1:{
					Console.WriteLine("Enter no. of passengers");
					int numberOfPassenger=int.Parse(Console.ReadLine());
					int stop=1;
					while(numberOfPassenger>0 && stop<5){
						Console.WriteLine("Currently at stop "+stop+" Want to get off at stop : "+stop+"\n1. Yes \n2. No \n3. Exit");
						int choice2=int.Parse(Console.ReadLine());
						switch(choice2){
							case 1:{
								Console.WriteLine("no. of Passenger getting off :");
								int num=int.Parse(Console.ReadLine());
								if(num>numberOfPassenger){
									Console.WriteLine("invalid no. of passengers,choose again\n");
									continue;
								}
								numberOfPassenger-=num;
								totalDistance+=Distance[stop-1];
								stop++;
								break;
							}
							case 2:{
								totalDistance+=Distance[stop-1];
								stop++;
								break;
							}
							case 3:{
								return totalDistance;
							}
						}
					}
					Console.WriteLine("journey ended ,get total distance");
					break;
				}
				case 2:{
					return totalDistance;
				}
				default:{
					Console.WriteLine("invalid choice");
					break;
				}
			}	
		}
	}
}

class BusDistanceTracker{
	static void Main(string[] args){
		BusRoute start=new BusRoute();
		Console.WriteLine("total distance travelled :"+start.StartJourney());
	}
}