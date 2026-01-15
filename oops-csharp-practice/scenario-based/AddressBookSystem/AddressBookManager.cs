using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    //class for creating and selecting different address books
    internal class AddressBookManager
    {
        private string[] addressBookNames;
        private AddressBookUtilityImpl[] addressBooks;
        private int count;

        public AddressBookManager(int capacity)
        {
            addressBookNames = new string[capacity];
            addressBooks = new AddressBookUtilityImpl[capacity];
            count = 0;
        }

        public void AddAddressBook()
        {
            if (count >= addressBookNames.Length)
            {
                Console.WriteLine("Storage full.\n");
                return;
            }

            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Address Book already exists.\n");
                    return;
                }
            }

            addressBookNames[count] = name;
            addressBooks[count] = new AddressBookUtilityImpl(100);
            count++;

            Console.WriteLine("Address Book created successfully.\n");
        }

        public AddressBookUtilityImpl SelectAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return addressBooks[i];
                }
            }

            Console.WriteLine("Address Book not found.\n");
            return null;
        }

        public void DisplayAllAddressBooks()
        {
            if (count == 0)
            {
                Console.WriteLine("No Address Books available! Add Address Books\n");
                return;
            }

            Console.WriteLine("Available Address Books:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("- " + addressBookNames[i]);
            }
            Console.WriteLine();
        }
    }
}
