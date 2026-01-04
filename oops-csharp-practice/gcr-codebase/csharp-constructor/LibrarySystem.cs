using System;

class Book{
    public string ISBN;
    protected string title;
    private string author;

    public Book(string isbn, string title, string author){
        this.ISBN = isbn;
        this.title = title;
        this.author = author;
    }

    public void SetAuthor(string author){
        this.author = author;
    }

    public string GetAuthor(){
        return author;
    }

    public void DisplayBook(){
        Console.WriteLine("ISBN   : " + ISBN);
        Console.WriteLine("Title  : " + title);
        Console.WriteLine("Author : " + author);
        Console.WriteLine("----------------------");
    }
}

class EBook : Book{
    private string fileFormat;

    public EBook(string isbn, string title, string author, string fileFormat)
        : base(isbn, title, author){
        this.fileFormat = fileFormat;
    }

    public void DisplayEBook(){
        Console.WriteLine("ISBN       : " + ISBN);
        Console.WriteLine("Title      : " + title);
        Console.WriteLine("FileFormat : " + fileFormat);
        Console.WriteLine("Author     : " + GetAuthor());
        Console.WriteLine("----------------------");
    }
}

class LibrarySystem{
    static void Main(string[] args){
        Book book = new Book("978-0132350884", "Clean Code", "Robert C. Martin");
        book.DisplayBook();
        book.SetAuthor("Uncle Bob");
        Console.WriteLine("Updated Author: " + book.GetAuthor());
        Console.WriteLine();
        EBook ebook = new EBook("978-0201616224", "The Pragmatic Programmer", "Andrew Hunt", "PDF");
        ebook.DisplayEBook();
    }
}
