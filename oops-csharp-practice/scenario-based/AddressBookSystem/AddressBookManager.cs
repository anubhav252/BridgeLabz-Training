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

        //method for searching person by city or state across all address books
        public void SearchPerson()
        {

            if (count == 0)
            {
                Console.WriteLine("No Address Books available! Add Address Books\n");
                return;
            }
            Console.Write("Enter City or State to search: ");
            string searchInput = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                AddressBookUtilityImpl book = addressBooks[i];

                for (int j = 0; j < book.GetContactCount(); j++)
                {
                    AddressBook person = book.GetContactAt(j);

                    if (person._City.Equals(searchInput, StringComparison.OrdinalIgnoreCase) ||
                        person._State.Equals(searchInput, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Address Book: " + addressBookNames[i]);
                        Console.WriteLine(person);
                        Console.WriteLine("------------------------");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No persons found in given city or state.\n");
            }
        }

    }
}
