using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookUtilityImpl : IAddressBook
    {
         // List instead of array / linked list
        private List<AddressBook> contacts = new List<AddressBook>();

        // Stack for undo delete
        private Stack<AddressBook> undoStack = new Stack<AddressBook>();
        public AddressBookUtilityImpl(int capacity)
        {
        }

        // Ability to add new  contact in address book (linked list)
        public void AddContact()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            // Duplicate check
            foreach (var c in contacts)
            {
                if (c._FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    c._LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
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

            contacts.Add(new AddressBook(
                firstName, lastName, address,
                city, state, zip, phone, email));

            Console.WriteLine("\nContact added successfully.\n");
        }

        // to display contacts in address book
        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
                Console.WriteLine("--------------------------");
            }
        }

        // method for editing contact using firstname and lastname
        public void EditContact()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            foreach (var contact in contacts)
            {
                if (contact._FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contact._LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter new details");

                    Console.Write("Address: ");
                    contact._Address = Console.ReadLine();
                    Console.Write("City: ");
                    contact._City = Console.ReadLine();
                    Console.Write("State: ");
                    contact._State = Console.ReadLine();
                    Console.Write("Zip: ");
                    contact._Zip = Console.ReadLine();
                    Console.Write("Phone Number: ");
                    contact._PhoneNumber = Console.ReadLine();
                    Console.Write("Email: ");
                    contact._Email = Console.ReadLine();

                    Console.WriteLine("Contact updated successfully.\n");
                    return;
                }
            }

            Console.WriteLine("Contact not found.\n");
        }
        // method to delete contact using name(Stack)
        public void DeleteContact()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i]._FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contacts[i]._LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    undoStack.Push(contacts[i]);
                    contacts.RemoveAt(i);

                    Console.WriteLine("Contact deleted successfully.\n");
                    return;
                }
            }

            Console.WriteLine("Contact not found.\n");
        }
        // method to add multiple contacts one by one
         public void AddMultipleContact()
        {
            Console.Write("Enter number of contacts: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                AddContact();
        }

        public int GetContactCount()
        {
            return contacts.Count;
        }

        // returns contacts details at given index
        public AddressBook GetContactAt(int index)
        {
            if (index < 0 || index >= contacts.Count)
                return null;
            return contacts[index];
        }

        //method for sorting contacts by the name
       public void SortContacts()
        {
            contacts.Sort((a, b) =>
                string.Compare(
                    a._FirstName + a._LastName,
                    b._FirstName + b._LastName,
                    StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\nContacts sorted alphabetically.\n");
            DisplayContacts();
        }
        //methods for sorting contacts by city/state/zip
        public void SortByCity()
        {
            if (contacts.Count < 2)
            {
                Console.WriteLine("Not enough contacts to sort.\n");
                return;
            }

            contacts.Sort((a, b) =>
                string.Compare(a._City, b._City, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\nContacts sorted by City:\n");
            DisplayContacts();
        }

        public void SortByState()
        {
            if (contacts.Count < 2)
            {
                Console.WriteLine("Not enough contacts to sort.\n");
                return;
            }

            contacts.Sort((a, b) =>
                string.Compare(a._State, b._State, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\nContacts sorted by State:\n");
            DisplayContacts();
        }
        public void SortByZip()
        {
            if (contacts.Count < 2)
            {
                Console.WriteLine("Not enough contacts to sort.\n");
                return;
            }

            contacts.Sort((a, b) =>
                string.Compare(a._Zip, b._Zip, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\nContacts sorted by Zip:\n");
            DisplayContacts();
        }
    }
}
