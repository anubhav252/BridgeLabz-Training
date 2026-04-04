using System;
using System.Collections.Generic;

class Book{
    public string Title;
    public string Author;

    public Book(string title, string author){
        Title = title;
        Author = author;
    }

    public void DisplayBook(){
        Console.WriteLine("Title  : " + Title);
        Console.WriteLine("Author : " + Author);
    }
}

class Library{
    public string LibraryName;
    private List<Book> books;

    public Library(string libraryName){
        LibraryName = libraryName;
        books = new List<Book>();
    }

    public void AddBook(Book book){
        books.Add(book);
    }

    public void DisplayLibraryBooks(){
        Console.WriteLine("\nLibrary: " + LibraryName);
        Console.WriteLine("Books Available:");

        foreach (Book book in books){
            book.DisplayBook();
            Console.WriteLine();
        }
    }
}

class LibraryAndBooks{
    static void Main(string[] args){
        Book b1 = new Book("Clean Code", "Robert C. Martin");
        Book b2 = new Book("The Pragmatic Programmer", "Andrew Hunt");
        Book b3 = new Book("Design Patterns", "Erich Gamma");

        Library lib1 = new Library("City Library");
        Library lib2 = new Library("College Library");

        lib1.AddBook(b1);
        lib1.AddBook(b2);

        lib2.AddBook(b2);
        lib2.AddBook(b3);

        lib1.DisplayLibraryBooks();
        lib2.DisplayLibraryBooks();
    }
}
