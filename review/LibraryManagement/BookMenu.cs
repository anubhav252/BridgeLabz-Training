using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementReviewQues
{
    internal class BookMenu
    {

        private IBookOperation utility = new BookUtility();
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("enter your choice \n1.add book \n2.search book \n3.change status \n4.display books \n5.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        utility.AddBook();
                        break;
                    case 2:
                        utility.SearchBook();
                        break;
                    case 3:
                        utility.ChangeStatus();
                        break;
                    case 4:
                        utility.DisplayBooks();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
        }
    }
}
