using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookUtilityImpl : IAddressBook
    {
        private AddressBook[] contacts;
        private int count;

        public AddressBookUtilityImpl(int capacity)
        {
            contacts = new AddressBook[capacity];
            count = 0;
        }

        public void AddContact()
        {
            if (count >= contacts.Length)
            {
                Console.WriteLine("Address Book is full.");
                return;
            }

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Zip: ");
            string zip = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            contacts[count] = new AddressBook(
                firstName, lastName, address,
                city, state, zip, phone, email);

            count++;

            Console.WriteLine("\nContact added successfully.\n");
        }

        public void DisplayContacts()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(contacts[i]);
                Console.WriteLine("--------------------------");
            }
        }
    }
}
