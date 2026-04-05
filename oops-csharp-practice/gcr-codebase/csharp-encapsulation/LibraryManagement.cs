using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    interface IReservable
    {
        bool IsAvailable();
        void Reserve();
    }

    abstract class LibraryItem
    {
        private int id;
        private string title;
        private string creator;
        private string borrower;
        protected bool available = true;

        public int Id
        {
            get { return id; }
            protected set { id = value; }
        }

        public string Title
        {
            get { return title; }
            protected set { title = value; }
        }

        public string Creator
        {
            get { return creator; }
            protected set { creator = value; }
        }

        protected string Borrower
        {
            get { return borrower; }
            set { borrower = value; }
        }

        protected LibraryItem(int id, string title, string creator)
        {
            Id = id;
            Title = title;
            Creator = creator;
        }

        public abstract int LoanPeriod();

        public void PrintDetails()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author/Creator: " + Creator);
            Console.WriteLine("Loan Period: " + LoanPeriod() + " days");
            Console.WriteLine("Available: " + available);
        }
    }

    class BookItem : LibraryItem, IReservable
    {
        public BookItem(int id, string title, string author) : base(id, title, author) { }

        public override int LoanPeriod()
        {
            return 15;
        }

        public bool IsAvailable()
        {
            return available;
        }

        public void Reserve()
        {
            if (available)
            {
                available = false;
                Borrower = "User";
            }
        }
    }

    class MagazineItem : LibraryItem, IReservable
    {
        public MagazineItem(int id, string title, string editor) : base(id, title, editor) { }

        public override int LoanPeriod()
        {
            return 7;
        }

        public bool IsAvailable()
        {
            return available;
        }

        public void Reserve()
        {
            if (available)
            {
                available = false;
                Borrower = "User";
            }
        }
    }

    class DvdItem : LibraryItem, IReservable
    {
        public DvdItem(int id, string title, string director) : base(id, title, director) { }

        public override int LoanPeriod()
        {
            return 4;
        }

        public bool IsAvailable()
        {
            return available;
        }

        public void Reserve()
        {
            if (available)
            {
                available = false;
                Borrower = "User";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LibraryItem[] collection = {
                new BookItem(101, "Object Oriented Design", "Martin"),
                new MagazineItem(202, "Science Weekly", "Editorial Team"),
                new DvdItem(303, "Interstellar", "Christopher Nolan")
            };

            foreach (LibraryItem item in collection)
            {
                item.PrintDetails();

                if (item is IReservable r)
                {
                    Console.WriteLine("Available Before: " + r.IsAvailable());
                    r.Reserve();
                    Console.WriteLine("Available After: " + r.IsAvailable());
                }

                Console.WriteLine("--------------");
            }
        }
    }
}
