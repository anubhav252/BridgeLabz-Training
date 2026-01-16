using System;

namespace BookShelf
{
    internal class BookShelfMain
    {
        static void Main(string[] args)
        {
            CustomHashMap library = new CustomHashMap(10);

            library.AddBook("Fiction", new Book("1984", "George Orwell"));
            library.AddBook("Fiction", new Book("Animal Farm", "George Orwell"));
            library.AddBook("Science", new Book("A Brief History of Time", "Stephen Hawking"));

            Console.WriteLine("\n--- Fiction Books ---");
            library.DisplayGenre("Fiction");

            Console.WriteLine("\n--- Borrowing Book ---");
            library.RemoveBook("Fiction", "1984");

            Console.WriteLine("\n--- Fiction Books After Borrow ---");
            library.DisplayGenre("Fiction");
        }
    }
}
