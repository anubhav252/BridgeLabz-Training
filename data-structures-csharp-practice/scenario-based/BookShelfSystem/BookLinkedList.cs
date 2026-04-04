using System;

namespace BookShelf
{
    internal class BookLinkedList
    {
        private BookNode head;

        public void AddBook(Book book)
        {
            if (Contains(book.Title))
            {
                Console.WriteLine("Duplicate book not allowed.");
                return;
            }

            BookNode newNode = new BookNode(book);
            newNode.Next = head;
            head = newNode;
        }

        public void RemoveBook(string title)
        {
            BookNode current = head;
            BookNode previous = null;

            while (current != null)
            {
                if (current.Data.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (previous == null)
                        head = current.Next;
                    else
                        previous.Next = current.Next;

                    Console.WriteLine("Book removed.");
                    return;
                }

                previous = current;
                current = current.Next;
            }

            Console.WriteLine("Book not found.");
        }

        public bool Contains(string title)
        {
            BookNode temp = head;
            while (temp != null)
            {
                if (temp.Data.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return true;
                temp = temp.Next;
            }
            return false;
        }

        public void Display()
        {
            BookNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
