using System;

class Book{
    public static string LibraryName = "City Central Library";

    public readonly string ISBN;
    private string Title;
    private string Author;

    public Book(string ISBN, string Title, string Author){
        this.ISBN = ISBN;
        this.Title = Title;
        this.Author = Author;
    }

    public static void DisplayLibraryName(){
        Console.WriteLine("Library Name: " + LibraryName);
    }

    public void DisplayBookDetails(){
        Console.WriteLine("ISBN   : " + ISBN);
        Console.WriteLine("Title  : " + Title);
        Console.WriteLine("Author : " + Author);
        Console.WriteLine("---------------------------");
    }
}

class LibraryManagementSystem{
    static void Main(string[] args){
        Book book1 = new Book("978-0132350884", "Clean Code", "Robert C. Martin");
        Book book2 = new Book("978-0201616224", "The Pragmatic Programmer", "Andrew Hunt");

        Book.DisplayLibraryName();
        Console.WriteLine();

        if (book1 is Book && book2 is Book){
            book1.DisplayBookDetails();
			book2.DisplayBookDetails();
        }
    }
}
