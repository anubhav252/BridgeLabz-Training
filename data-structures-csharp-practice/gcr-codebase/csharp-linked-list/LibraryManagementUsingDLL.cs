using System;

namespace LibraryManagementUsingDLL
{
   class BookNode
   {
       public int BookId;
       public string Title;
       public string Author;
       public string Genre;
       public bool IsAvailable;
       public BookNode Next;
       public BookNode Previous;

       public BookNode(int id, string title, string author, string genre, bool available)
       {
           BookId = id;
           Title = title;
           Author = author;
           Genre = genre;
           IsAvailable = available;
           Next = null;
           Previous = null;
       }
   }

   class Library
   {
       private BookNode head;
       private BookNode tail;

       public void AddAtBeginning(int id, string title, string author, string genre, bool available)
       {
           BookNode newNode = new BookNode(id, title, author, genre, available);

           if (head == null)
           {
               head = tail = newNode;
               return;
           }

           newNode.Next = head;
           head.Previous = newNode;
           head = newNode;
       }

       public void AddAtEnd(int id, string title, string author, string genre, bool available)
       {
           BookNode newNode = new BookNode(id, title, author, genre, available);

           if (tail == null)
           {
               head = tail = newNode;
               return;
           }

           tail.Next = newNode;
           newNode.Previous = tail;
           tail = newNode;
       }

       public void AddAtPosition(int id, string title, string author, string genre, bool available, int position)
       {
           if (position <= 1)
           {
               AddAtBeginning(id, title, author, genre, available);
               return;
           }

           BookNode temp = head;
           for (int i = 1; i < position - 1 && temp != null; i++)
           {
               temp = temp.Next;
           }

           if (temp == null || temp.Next == null)
           {
               AddAtEnd(id, title, author, genre, available);
               return;
           }

           BookNode newNode = new BookNode(id, title, author, genre, available);
           newNode.Next = temp.Next;
           newNode.Previous = temp;
           temp.Next.Previous = newNode;
           temp.Next = newNode;
       }

       public void RemoveByBookId(int id)
       {
           BookNode temp = head;

           while (temp != null)
           {
               if (temp.BookId == id)
               {
                   if (temp == head)
                       head = temp.Next;

                   if (temp == tail)
                       tail = temp.Previous;

                   if (temp.Previous != null)
                       temp.Previous.Next = temp.Next;

                   if (temp.Next != null)
                       temp.Next.Previous = temp.Previous;

                   Console.WriteLine("Book removed successfully");
                   return;
               }
               temp = temp.Next;
           }

           Console.WriteLine("Book not found");
       }

       public void SearchByTitle(string title)
       {
           BookNode temp = head;
           bool found = false;

           while (temp != null)
           {
               if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
               {
                   DisplayBook(temp);
                   found = true;
               }
               temp = temp.Next;
           }

           if (!found)
               Console.WriteLine("No book found with given title");
       }

       public void SearchByAuthor(string author)
       {
           BookNode temp = head;
           bool found = false;

           while (temp != null)
           {
               if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
               {
                   DisplayBook(temp);
                   found = true;
               }
               temp = temp.Next;
           }

           if (!found)
               Console.WriteLine("No books found by this author");
       }

       public void UpdateAvailability(int id, bool status)
       {
           BookNode temp = head;

           while (temp != null)
           {
               if (temp.BookId == id)
               {
                   temp.IsAvailable = status;
                   Console.WriteLine("Availability updated");
                   return;
               }
               temp = temp.Next;
           }

           Console.WriteLine("Book not found");
       }

       public void DisplayForward()
       {
           if (head == null)
           {
               Console.WriteLine("Library is empty");
               return;
           }

           BookNode temp = head;
           while (temp != null)
           {
               DisplayBook(temp);
               temp = temp.Next;
           }
       }

       public void DisplayReverse()
       {
           if (tail == null)
           {
               Console.WriteLine("Library is empty");
               return;
           }

           BookNode temp = tail;
           while (temp != null)
           {
               DisplayBook(temp);
               temp = temp.Previous;
           }
       }

       public int CountBooks()
       {
           int count = 0;
           BookNode temp = head;

           while (temp != null)
           {
               count++;
               temp = temp.Next;
           }

           return count;
       }

       private void DisplayBook(BookNode book)
       {
           Console.WriteLine("Book ID: " + book.BookId +", Title: " + book.Title +", Author: " + book.Author +", Genre: " + book.Genre +", Available: " + (book.IsAvailable ? "Yes" : "No"));
       }
   }

   class LibraryMain
   {
       static void Main(string[] args)
       {
           Library library = new Library();

           library.AddAtEnd(101, "Clean Code", "Robert Martin", "Programming", true);
           library.AddAtBeginning(102, "The Alchemist", "Paulo Coelho", "Fiction", true);
           library.AddAtPosition(103, "1984", "George Orwell", "Dystopian", false, 2);
           library.AddAtEnd(104, "The Hobbit", "J.R.R. Tolkien", "Fantasy", true);

           Console.WriteLine("Books (Forward):");
           library.DisplayForward();

           Console.WriteLine("\nBooks (Reverse):");
           library.DisplayReverse();

           Console.WriteLine("\nSearch by Title:");
           library.SearchByTitle("1984");

           Console.WriteLine("\nSearch by Author:");
           library.SearchByAuthor("Paulo Coelho");

           Console.WriteLine("\nUpdate Availability:");
           library.UpdateAvailability(103, true);

           Console.WriteLine("\nRemove Book:");
           library.RemoveByBookId(102);

           Console.WriteLine("\nTotal Books: " + library.CountBooks());

           Console.WriteLine("\nFinal Library:");
           library.DisplayForward();
       }
   }
}
