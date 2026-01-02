using System;
class LuckyDraw{
	public void CheckWinner(int numberChosen){
		if(numberChosen%3==0 && numberChosen%5==0){
			Console.WriteLine("Congrats u win!");
		}
		else{
			Console.WriteLine("better luck next time");
		}
	}
}

class FestivakLuckyDraw{
	static void Main(string[] args){
		LuckyDraw checker=new LuckyDraw();
		while(true){
			Console.WriteLine("\nEnter Choice");
			Console.WriteLine("1. Play \n2.Exit");
			int choice =int.Parse(Console.ReadLine());
			switch(choice){
				case 1:{
					Console.WriteLine("enter input :");
					int input=int.Parse(Console.ReadLine());
					if(input<=0){
						Console.WriteLine("invalid");
						continue;
					}
					checker.CheckWinner(input);
					break;
				}
				case 2:{
					return;
				}
				default:{
					break;
				}
			}
		}
	}
}
