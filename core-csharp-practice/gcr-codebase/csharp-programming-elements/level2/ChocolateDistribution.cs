using System;

class ChocolateDistribution{
	static void Main(string[] args){
		int numOfChocolate = Convert.ToInt32(Console.ReadLine());
		int numOfChildren = Convert.ToInt32(Console.ReadLine());
		
		int chocalatePerChild = numOfChocolate/numOfChildren;
		int remainings = numOfChocolate%numOfChildren;
		
		Console.WriteLine("The number of chocolates each child gets is "+chocalatePerChild+
		" and the number of remaining chocolates is "+ remainings);
	}
}

