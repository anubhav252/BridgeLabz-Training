using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LibraryManagementReviewQues
{
    internal class BookUtility : IBookOperation
    {
        private Book[] books=new Book[10];
        private int count = 0;
        public void AddBook() {
            if (count >= 10)
            {
                Console.WriteLine("storage full");
                return;
            }
            Console.WriteLine("enter book title");
            string title = Console.ReadLine();
            Console.WriteLine("enter book author name");
            string author= Console.ReadLine();
            Console.WriteLine("enter status of the book");
            string status=Console.ReadLine();
            books[count]=new Book(title, author, status);
            count++;
            Console.WriteLine("book added successfuly");
        }

        public void SearchBook()
        {
            if (books == null)
            {
                Console.WriteLine("no book! add book first");
                return;
            }
            Console.WriteLine("enter book to be searched");
            string searchBook = Console.ReadLine();
            for (int i = 0; i <= count; i++)
            {
                if (books[i]._Title.Contains(searchBook, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(books[i]);
                    return;
                }
            }
            Console.WriteLine("book not found");
        }

        public void ChangeStatus()
        {
            if (books == null)
            {
                Console.WriteLine("no book! add book first");
                return;
            }
            Console.WriteLine("enter book title");
            string changeStatusOfBook=Console.ReadLine();
            for(int i = 0; i <= count; i++)
            {
                if (books[i]._Title.Contains(changeStatusOfBook, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(books[i]);
                    Console.WriteLine("enter corresponding choice \n1.to change \n2.Exit");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        if (books[i]._Status == "Available")
                        {
                            books[i]._Status = "Reserved";
                            Console.WriteLine(books[i]);
                            return;
                        }
                        else
                        {
                            books[i]._Status = "Available";
                            Console.WriteLine(books[i]);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("book not found");
        }
        public void DisplayBooks()
        {
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(books[i]);
            }
        }
    }
}
