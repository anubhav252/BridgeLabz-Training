using System;
class UniversityFeeInput{
	static void Main(){
		int fee=Convert.ToInt32(Console.ReadLine());
		int discountPerc=Convert.ToInt32(Console.ReadLine());
		int discount=(fee/100)*discountPerc;
		int feeToPay=fee-discount;
		Console.WriteLine("The discount amount is INR "+ discount +
		" and final discounted fee is INR " + feeToPay);
	}
}	