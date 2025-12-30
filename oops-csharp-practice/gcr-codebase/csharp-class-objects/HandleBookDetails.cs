using System;
class Book{
	private string Title;
	private string Author;
	private float Price;
	
	public Book(string title,string author,float price){
		this.Title=title;
		this.Author=author;
		this.Price=price;
	}
	
	public void DisplayDetails(){
		Console.WriteLine(Title);
		Console.WriteLine(Author);
		Console.WriteLine("$"+Price);
	}
}

class HandleBookDetails{
	static void Main(string[] args){
		Book obj=new Book("Harry Potter","j.k rollins",799.00f);
		obj.DisplayDetails();
	}
}