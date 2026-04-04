using System;
class Book{
	string Title;
	string Author;
	float Price;
	
	public Book(){
		Title="Harry Potter";
		Author="J.K Rollins";
		Price=599.0f;
	}
	
	public Book(string title,string author,float price){
		Title=title;
		Author=author;
		Price=price;
	}
	
	public void Display(){
		Console.WriteLine("Title : "+Title+"\nAuthor : "+Author+"\nPrice : "+Price);
	}
}

class Program{
	static void Main(string[] args){
		Book book1=new Book();
		Book book2=new Book("abdbd","iereiq",789.0f);
		book1.Display();
		book2.Display();
	}
}