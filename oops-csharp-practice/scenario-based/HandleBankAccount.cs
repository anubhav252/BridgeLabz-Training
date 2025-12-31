/* 1. Scenario: A banking app needs to perform operations like deposit, withdraw, and check balance for a user.
● Problem: Design a BankAccount class with:
● Fields/Properties: AccountNumber, Balance.
● Methods: Deposit(double), Withdraw(double), CheckBalance().
● Include logic to prevent overdraft. */
using System;

class Bank{
    private static string BankName;
    private string Branch;
    private string IFSCCode;
    private double MinimumBalance;
    private double MaximumTransaction;

    public Bank(string bankName, string branch, string ifscCode, double minBalance, double maxTransaction){
        BankName = bankName;
        Branch = branch;
        IFSCCode = ifscCode;
        MinimumBalance = minBalance;
        MaximumTransaction = maxTransaction;
    }

    public void DisplayBankDetails(){
        Console.WriteLine("Bank Name: " + BankName);
        Console.WriteLine("Branch Name: " + Branch);
        Console.WriteLine("IFSC Code: " + IFSCCode);
        Console.WriteLine("Minimum Balance: " + MinimumBalance);
        Console.WriteLine("Maximum Transaction: " + MaximumTransaction);
    }
}

class AccountHolder{
    private long AccountNo;
    private double CurrentBalance;
    private double LastDeposit;
    private double LastWithdrawal;

    public AccountHolder(long accountNo, double currentBalance){
        AccountNo = accountNo;
        CurrentBalance = currentBalance;
    }

    public void Deposit(){
        Console.Write("Enter deposit amount: ");
        double amount = double.Parse(Console.ReadLine());
        LastDeposit = amount;
        CurrentBalance += amount;
        Console.WriteLine("Deposit successful. Balance: " + CurrentBalance);
    }

    public void Withdraw(){
        Console.Write("Enter withdrawal amount: ");
        double amount = double.Parse(Console.ReadLine());

        if (amount > CurrentBalance){
            Console.WriteLine("Insufficient balance.");
            return;
        }

        LastWithdrawal = amount;
        CurrentBalance -= amount;
        Console.WriteLine("Withdrawal successful. Balance: " + CurrentBalance);
    }

    public void CheckBalance(){
        Console.WriteLine("Current Balance: " + CurrentBalance);
    }

    public double GetLastDeposit(){
        return LastDeposit;
    }

    public double GetLastWithdrawal(){
        return LastWithdrawal;
    }
}

class AccountManager{
    private AccountHolder account;

    public AccountManager(AccountHolder acc){
        account = acc;
    }
}

class HandleBankAccount{
    private Bank bank;
    private AccountHolder account;
    private AccountManager manager;

    static void Main(string[] args){
        HandleBankAccount obj = new HandleBankAccount();
        obj.GetInput();
        obj.Menu();
    }

    public void GetInput(){
        bank = new Bank("BOB", "Ajai Khurd", "HDIWH239338HDU", 2000, 100000);

       
        long accNo = 216468764864;

        double balance = 1000;

        account = new AccountHolder(accNo, balance);
        manager = new AccountManager(account);
    }

    public void Menu(){
        string password = "anubhav";

        while (true){
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Account Manager");
            Console.WriteLine("2. Account Holder");
            Console.WriteLine("3. Bank Details");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1:
                    Console.Write("Enter password: ");
                    string pass = Console.ReadLine();

                    if (pass == password){
						bool flag1=true;
                        while (flag1){
							Console.WriteLine("\n--- Account Manager Menu ---");
							Console.WriteLine("1. View Last Deposit");
							Console.WriteLine("2. View Last Withdrawal");
							Console.WriteLine("3. View Balance");
							Console.WriteLine("4. Back");
				
							int choice2 = int.Parse(Console.ReadLine());
				
							switch (choice2){
								case 1:
									Console.WriteLine("Last Deposit: " + account.GetLastDeposit());
									break;
					
								case 2:
									Console.WriteLine("Last Withdrawal: " + account.GetLastWithdrawal());
									break;
					
								case 3:
									account.CheckBalance();
									break;
					
								case 4:
								    flag1=false;
									break;
					
								default:
									Console.WriteLine("Invalid choice.");
									break;
							}
						}
					}
                    else
                        Console.WriteLine("Wrong password.");
                    break;

                case 2:
					bool flag2=true;
                    while (flag2){
						Console.WriteLine("\n--- Account Holder Menu ---");
						Console.WriteLine("1. Deposit");
						Console.WriteLine("2. Withdraw");
						Console.WriteLine("3. Check Balance");
						Console.WriteLine("4. Back");
			
						int choice3 = int.Parse(Console.ReadLine());
			
						switch (choice3){
							case 1:
								account.Deposit();
								break;
				
							case 2:
								account.Withdraw();
								break;
				
							case 3:
								account.CheckBalance();
								break;
				
							case 4:
							    flag2=false;
								break;
				
							default:
								Console.WriteLine("Invalid choice.");
								break;
						}
					}
				    break;

                case 3:
                    bank.DisplayBankDetails();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
