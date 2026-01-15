using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookMenu
    {
        private IAddressBook currentBook;
        private AddressBookManager manager;

        public AddressBookMenu()
        {
            //addressBook = new AddressBookUtilityImpl(100);
            manager = new AddressBookManager(10);
        }

        //menu for addres book operations
        public void AddressBookOperationMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Add Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Show All Address Books");
                Console.WriteLine("4. Search Person by City or State");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddAddressBook();
                        break;
                    case 2:
                        currentBook = manager.SelectAddressBook();
                        if (currentBook != null)
                        {
                            ShowMenu();
                        }
                        break;
                    case 3:
                        manager.DisplayAllAddressBooks();
                        break;
                    case 4:
                        manager.SearchPerson();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.\n");
                        break;
                }
            }

        }
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Add Multiple Contact");
                Console.WriteLine("6. Back");
                Console.Write("Enter choice: ");
                Console.WriteLine("---------------------------------");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        currentBook.AddContact();
                        break;
                    case 2:
                        currentBook.DisplayContacts();
                        break;
                    case 3:
                        currentBook.EditContact();
                        break;
                    case 4:
                        currentBook.DeleteContact();
                        break;
                    case 5:
                        currentBook.AddMultipleContact();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Enter again--");
                        break;
                }
            }
        }
    }
}
