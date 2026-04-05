using System;
class LibraryManagement{
	
    static void Main(string[] args){
	LibraryManagement obj=new LibraryManagement();
	obj.GetInput();
	}
	
	void GetInput(){
		//int numberOfBooks=int.Parse(Console.ReadLine());
		int numberOfBooks=6;
		int columns=3;
		string[,] booksDetails ={
            { "Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "Available" },
            { "The Hobbit", "J.R.R. Tolkien", "Checked Out" },
            { "Clean Code", "Robert C. Martin", "Available" },
            { "Java Programming Basics", "James Gosling", "Available" },
            { "Effective Java", "Joshua Bloch", "Checked Out" },
            { "C# in Depth", "Jon Skeet", "Available" }
			};
		/*
		string[,] bookDetails=new string[numberOfBooks,3];
		for(int i=0;i<numberOfBooks;i++){
			for(int j=0;j<3;j++){
				bookDetails[i,j]=Console.ReadLine();
			}
		}
		*/
		LibraryManagement obj=new LibraryManagement();
		obj.Menu(booksDetails,numberOfBooks,columns);
	}
	
	
	void Menu(string[,] booksDetails,int numberOfBooks,int columns){
		LibraryManagement obj=new LibraryManagement();
		while(true){
			Console.WriteLine();
			Console.WriteLine("Enter your choice : ");
			Console.WriteLine("1. Display Books \n2. Search Books \n3. Update Status \n4. Exit");
			int choice=int.Parse(Console.ReadLine());
			Console.WriteLine();
			switch(choice){
				case 1:{
					obj.DisplayBooks(booksDetails,numberOfBooks,columns);
					break;
				}
				case 2:{
					obj.SearchBook(booksDetails,numberOfBooks,columns);
					break;
				}
				case 3:{
					obj.UpdateStatus(booksDetails,numberOfBooks,columns);
					break;
				}
				case 4:{
					return;
				}
				default:{
					Console.WriteLine("invalid input");
					break;
				}
			}
		}
		
		
	}
	
	
	void DisplayBooks(string[,] booksDetails,int numberOfBooks,int columns){
		for(int i=0;i<numberOfBooks;i++){
			for(int j=0;j<columns;j++){
				Console.Write(booksDetails[i,j]+" / ");
			}
			Console.WriteLine();
		}
	}
	
	
	void SearchBook(string[,] booksDetails,int numberOfBooks,int columns){
		string bookName=Console.ReadLine();
		string bookToBeSearched=bookName.Trim();
		
		for(int i=0;i<numberOfBooks;i++){
			if((booksDetails[i,0].ToLower()).Contains(bookToBeSearched.ToLower())){
				Console.WriteLine(booksDetails[i,0]+" / " +booksDetails[i,1]+" / "+booksDetails[i,2]);
			}		
		}	
	}
	
	
	void UpdateStatus(string[,] booksDetails,int numberOfBooks,int columns){
		string nameOfBook=Console.ReadLine();
		for(int i=0;i<numberOfBooks;i++){
			if(booksDetails[i,0]==nameOfBook){
				Console.WriteLine(booksDetails[i,0]+" / " +booksDetails[i,1]+" / "+booksDetails[i,2]);
				Console.WriteLine("1. Change Status \n2. Exit");
				int update=int.Parse(Console.ReadLine());
				if(update==1){
					if(booksDetails[i,2]=="Available"){
						booksDetails[i,2]="Checked Out";
						Console.WriteLine("updated status : "+booksDetails[i,0]+" / " +booksDetails[i,1]+" / "+booksDetails[i,2]);
					}
					else{
						booksDetails[i,2]="Available";
						Console.WriteLine("updated status : "+booksDetails[i,0]+" / " +booksDetails[i,1]+" / "+booksDetails[i,2]);
					}
				}
				else if(update==2){
					break;
				}
				else{
					Console.WriteLine("invalid input");
					break;
				}		
			}
		}
	}
}
