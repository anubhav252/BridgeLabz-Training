using System;
class CafeteriaMenu{
	public static string[] Items;
	
	public CafeteriaMenu(){
		
		Items=new string[10]{"Cheese Pizza","Chicken Burger","Vegetable Sandwich","French Fries","Grilled Chicken Wrap","Pasta Alfredo","Caesar Salad","Tomato Soup","Fried Rice","Chocolate Brownie"};
	}
	
	public void DisplayMenu(){
		Console.WriteLine("--------Menu--------");
		for(int i=0;i<Items.Length;i++){
			Console.WriteLine((i+1)+". "+Items[i]);
		}
	}
	
	public void GetItemByIndex(int[] orders){
		Console.WriteLine("-----------Your Order------------");
		for(int i=0;i<orders.Length;i++){
			Console.WriteLine((i+1)+". "+Items[orders[i]-1]);
		}
	}
}

class Program{
	static void Main(string[] args){
		CafeteriaMenu menu=new CafeteriaMenu();
		menu.DisplayMenu();
		Console.WriteLine("--------Place order---------");
		Console.WriteLine("no. of items");
		int n=int.Parse(Console.ReadLine());
		int[] orders=new int[n];
		Console.WriteLine("place order ");
		for(int i=0;i<n;i++){
			orders[i]=int.Parse(Console.ReadLine());
		}
		
		menu.GetItemByIndex(orders);
	}
}