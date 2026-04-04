using System;
class SnakeAndLadderGame{
	static Random random = new Random();
	
	static void Main(string[] args){		
		Console.WriteLine("Enter Number Of Players");
		int numberOfPlayers = int.Parse(Console.ReadLine());
		
		int[] players = new int[numberOfPlayers];
		
		string[] names=new string[numberOfPlayers];
		Console.WriteLine("Enter player names : ");
		for(int i=0;i<numberOfPlayers;i++){
			names[i]=(Console.ReadLine());
		}
		
		bool start= true;
		
		
		while(start){
			Console.WriteLine();
			Console.WriteLine("1. Start");
			Console.WriteLine("2. End");
			Console.WriteLine();
			int choose = int.Parse(Console.ReadLine());
			switch(choose){
				case 1:
					players = MovePlayer(players,names);
					for(int i=0;i<numberOfPlayers;i++){
						if(players[i] == -1){
							Console.WriteLine("Player "+names[i]+" WON THE GAME");
							start = false;
							break;
						}
						Console.WriteLine("Player "+names[i]+" at "+ players[i]);
					}
					break;
				case 2:
					start = false;
					break;
					
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}
		}
	}
	
	static int RollDice(){
		int val = random.Next(1,7);
		
		return val;
	}
	
	static int[] MovePlayer(int[] players,string[] names){
		int tempValue =0;
		int newPosition =0;
		int count =0;
		for(int i=0;i<players.Length;i++){
			tempValue =0;
			newPosition =0;
			count=0;
			tempValue = RollDice();
			Console.WriteLine("Player "+names[i]+" got : " + tempValue);
			newPosition = tempValue+ ApplySnakeOrLadder(players[i], tempValue);
			count = players[i] + newPosition;
			if(CheckWin(count)){
				players[i] = -1;
				break;
			}
			
			if(count>100)
				continue;
			else
				players[i] = count;
			
			
		}
		return players;
	}
	
	static int ApplySnakeOrLadder(int move, int n){
		int tempValue = move+n;
		if(tempValue == 10)
			return 18;
		else if(tempValue == 22)
			return 29;
		else if(tempValue == 59)
			return 8;
		else if(tempValue == 76)
			return 10;
		else if(tempValue == 18)
			return -10;
		else if(tempValue == 67)
			return -47;
		else if(tempValue == 99)
			return -62;
		else if(tempValue == 57)
			return -39;
		else
			return 0;
	}
	
	static bool CheckWin(int i){
		
		return (i == 100) ? true : false;

	}
	
	
	
}