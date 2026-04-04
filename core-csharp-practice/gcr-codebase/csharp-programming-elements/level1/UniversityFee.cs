using System;
class UniversityFee{
	static void Main(){
		int fee=125000;
		int discountPerc=10;
		int discount=(fee/100)*discountPerc;
		int feeToPay=fee-discount;
		Console.WriteLine("The discount amount is INR "+ discount +
		" and final discounted fee is INR " + feeToPay);
	}
}	