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
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Add Multiple Contact");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                Console.WriteLine("---------------------------------");

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
                        addressBook.EditContact();
                        break;
                    case 4:
                        addressBook.DeleteContact();
                        break;
                    case 5:
                        addressBook.AddMultipleContact();
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
