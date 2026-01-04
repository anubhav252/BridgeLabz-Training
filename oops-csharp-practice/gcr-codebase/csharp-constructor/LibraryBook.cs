using System;

class Book{
    private string title;
    private string author;
    private double price;
    private bool isAvailable;

    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
        this.isAvailable = true;
    }

    public void BorrowBook(){
        if (isAvailable){
            isAvailable = false;
            Console.WriteLine("Book borrowed successfully.");
        }
        else{
            Console.WriteLine("Book is not available.");
        }
    }

    public void DisplayDetails(){
        Console.WriteLine("Title : " + title);
        Console.WriteLine("Author : " + author);
        Console.WriteLine("Price : " + price);
        Console.WriteLine("Availability : " + (isAvailable ? "Available" : "Borrowed"));
     
    }
}

class TestLibrary{
    static void Main(string[] args){
        Book book1 = new Book("Clean Code", "Robert C. Martin", 450);
        book1.DisplayDetails();
        book1.BorrowBook();
        book1.DisplayDetails();
        book1.BorrowBook();
    }
}
