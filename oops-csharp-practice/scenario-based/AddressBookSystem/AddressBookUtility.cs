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

        // Ability to add new  contact in address book 
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
            //to check duplicate entries
            for (int i = 0; i < count; i++)
            {
                if (contacts[i]._FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && contacts[i]._LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Duplicate entry found! Contact not added.\n");
                    return;
                }
            }
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
        // to display contacts in address book
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
        // method for editing contact using firstname and lastname
        public void EditContact()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts available! Add Contacts First");
                return;
            }
            Console.Write("Enter first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name : ");
            string lastName = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (contacts[i]._FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contacts[i]._LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter new details");

                    Console.Write("Address: ");
                    contacts[i]._Address = Console.ReadLine();

                    Console.Write("City: ");
                    contacts[i]._City = Console.ReadLine();

                    Console.Write("State: ");
                    contacts[i]._State = Console.ReadLine();

                    Console.Write("Zip: ");
                    contacts[i]._Zip = Console.ReadLine();

                    Console.Write("Phone Number: ");
                    contacts[i]._PhoneNumber = Console.ReadLine();

                    Console.Write("Email: ");
                    contacts[i]._Email = Console.ReadLine();
                    Console.WriteLine("Contact updated successfully.\n");
                    return;
                }
            }

            Console.WriteLine("Contact not found.\n");
        }

        // method to delete contact using name
        public void DeleteContact()
        {
            if (count == 0)
            {
                Console.WriteLine("no contacts! add contacts first");
                return;
            }
            Console.Write("Enter first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name : ");
            string lastName = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {

                if (contacts[i]._FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contacts[i]._LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }

                    contacts[count - 1] = null;
                    count--;

                    Console.WriteLine("Contact deleted successfully.\n");
                    return;
                }
            }
        Console.WriteLine("Contact not found.\n");
        }

        // method to add multiple contacts one by one
        public void AddMultipleContact()
        {
            Console.WriteLine("Enter no. of contacts");
            int numberOfContact=int.Parse(Console.ReadLine());
            for(int i = 1; i <= numberOfContact; i++)
            {
                AddContact();
            }
        }

        public int GetContactCount()
        {
            return count;
        }

        // returns contacts details at given index
        public AddressBook GetContactAt(int index)
        {
            if (index < 0 || index >= count)
            {
                return null;
            }
            return contacts[index];
        }

    }
}
