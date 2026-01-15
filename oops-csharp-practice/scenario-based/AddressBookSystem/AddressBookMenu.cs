using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookMenu
    {
        private IAddressBook addressBook;

        public AddressBookMenu()
        {
            addressBook = new AddressBookUtilityImpl(100);
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.DisplayContacts();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
