using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    class BookMenu
    {
        BookUtility utility = new BookUtility();
        public void Menu()
        {
            Console.WriteLine("Enter your choice");
            while (true)
            {
                Console.WriteLine($"1.Add Books \n2.Sort Books \n3.Update book \n4.Search book \n5.Display books \n6.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        utility.AddBook();
                        break;
                    case 2:
                        utility.SortBooksAlphabetically();
                        break;
                    case 3:
                        utility.UpdateBook();
                        break;
                    case 4:
                        utility.SearchByAuthor();
                        break;
                    case 5:
                        utility.DisplayBooks();
                        break;
                    default:
                        Console.WriteLine("invalid choice! enter again");
                        break;
                }
            }
        }
    }
}
