using System;
class BankAccount{
	static string bankName="BoB";
	static int totalAccount;
	readonly long accNumber;
	string accHolderName;

    public BankAccount(long accNumber,string accHolderName){
		this.accHolderName=accHolderName;
		this.accNumber=accNumber;
		totalAccount++;
	}

	public static int GetTotalAccount(){
		return totalAccount;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("Bank Name : "+bankName+"\nAccount number : "+accNumber+"\nAccount holder name : "+accHolderName+"\n-------------------------------");
	}
}

class BankAccountSystem{
	static void Main(string[] args){
		BankAccount acc1=new BankAccount(1234567654,"Anubhav");
		BankAccount acc2=new BankAccount(1234554323,"sam");
		if(acc1 is BankAccount && acc2 is BankAccount){
			acc1.DisplayDetails();
			acc2.DisplayDetails();
		}
		
		Console.WriteLine(BankAccount.GetTotalAccount());
	}
}
