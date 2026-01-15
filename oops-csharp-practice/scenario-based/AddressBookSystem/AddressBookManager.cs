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

        //method for viewing person by city or state
        public void ViewPersons()
        {
            string[] cityNames = new string[50];
            AddressBook[][] cityPersons = new AddressBook[50][];
            int cityCount = 0;

            string[] stateNames = new string[50];
            AddressBook[][] statePersons = new AddressBook[50][];
            int stateCount = 0;

            for (int i = 0; i < count; i++)
            {
                AddressBookUtilityImpl book = addressBooks[i];

                for (int j = 0; j < book.GetContactCount(); j++)
                {
                    AddressBook person = book.GetContactAt(j);

                    AddToGroup(
                        person._City,
                        person,
                        cityNames,
                        cityPersons,
                        ref cityCount
                    );

                    AddToGroup(
                        person._State,
                        person,
                        stateNames,
                        statePersons,
                        ref stateCount
                    );
                }
            }

            Console.WriteLine("\nView By:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                DisplayGroup(cityNames, cityPersons, cityCount, "City");
            }
            else if (choice == 2)
            {
                DisplayGroup(stateNames, statePersons, stateCount, "State");
            }
        }

        private void AddToGroup(
    string key,
    AddressBook person,
    string[] keys,
    AddressBook[][] values,
    ref int keyCount)
        {
            for (int i = 0; i < keyCount; i++)
            {
                if (keys[i].Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    AppendPerson(values[i], person);
                    return;
                }
            }

            keys[keyCount] = key;
            values[keyCount] = new AddressBook[50];
            values[keyCount][0] = person;
            keyCount++;
        }

        private void AppendPerson(AddressBook[] group, AddressBook person)
        {
            for (int i = 0; i < group.Length; i++)
            {
                if (group[i] == null)
                {
                    group[i] = person;
                    return;
                }
            }
        }

        private void DisplayGroup(
            string[] keys,
            AddressBook[][] values,
            int count,
            string label)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n{label}: {keys[i]}");
                Console.WriteLine("-------------------");

                for (int j = 0; j < values[i].Length; j++)
                {
                    if (values[i][j] != null)
                    {
                        Console.WriteLine(values[i][j]);
                    }
                }
            }
        }

    }
}
