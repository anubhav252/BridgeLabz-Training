/* Invoice Generator for Freelancers
Focus: Strings, Methods
● Scenario: You're building an app for freelancers to generate invoice descriptions.
 Requirements:
● Accept input like: "Logo Design - 3000 INR, Web Page - 4500 INR".
● Split the string to extract task names and amounts.
● Calculate total invoice amount.
● Example Methods:
● ParseInvoice(string input)
● GetTotalAmount(string[] splitByComma) */

using System;
class InvoiceGenrator{
	public int[] ParseInvoice(string input){
		string[] splitByComma = input.Split(',');
        int[] amounts = new int[splitByComma.Length];

        for (int i = 0; i < splitByComma.Length; i++)
        {
            string[] parts = splitByComma[i].Split('-');
            string[] amountPart = parts[1].Trim().Split(' ');
            amounts[i] = int.Parse(amountPart[0]);
        }

        return amounts;
	}
	
	public void GetTotal(string input){
		int[] amount=ParseInvoice(input);
		int total=0;
		for(int i=0;i<amount.Length;i++){

				total+=amount[i];
			
		}
		
		Console.WriteLine("total amount is :"+total);
	}
}


class GenerateInvoice{
	static void Main(string[] args){
		InvoiceGenrator parse=new InvoiceGenrator();
		string input=Console.ReadLine();
		parse.GetTotal(input);	
	}
	
}