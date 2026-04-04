using System;
class CalculateProfit{
	static void Main(){
		int costPrice=129;
		int sellPrice=191;
		int profit=191-129;
		double profitPercent=(double)profit/costPrice * 100;
		Console.WriteLine("The cost price is INR 129 and selling price is INR 191\n" +
		"The profit is INR  "+profit +" and the profit percentage is " + profitPercent);
	}
}	