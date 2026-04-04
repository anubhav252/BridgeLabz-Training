using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookUtilityImpl : IAddressBook
    {
        private ContactNode head;
        private int count;

        // Stack for undo delete
        private Stack<AddressBook> undoStack = new Stack<AddressBook>();

        // // Queue for recently viewed contacts
        // private Queue<AddressBook> recentQueue = new Queue<AddressBook>();
        public AddressBookUtilityImpl(int capacity)
        {
            head = null;
            count = 0;
        }

        // Ability to add new  contact in address book (linked list)
        public void AddContact()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            // Duplicate check
            ContactNode temp = head;
            while (temp != null)
            {
                if (temp.Data._FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    temp.Data._LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Duplicate entry found! Contact not added.\n");
                    return;
                }
                temp = temp.Next;
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

            AddressBook contact = new AddressBook(
                firstName, lastName, address,
                city, state, zip, phone, email);

            ContactNode newNode = new ContactNode(contact);

            if (head == null)
                head = newNode;
            else
            {
                temp = head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = newNode;
            }

            count++;
            Console.WriteLine("\nContact added successfully.\n");
        }
        // to display contacts in address book
         public void DisplayContacts()
        {
            if (head == null)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            ContactNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                Console.WriteLine("--------------------------");
                temp = temp.Next;
            }
        }

        // method for editing contact using firstname and lastname
        public void EditContact()
        {
            if (head == null)
            {
                Console.WriteLine("No contacts available! Add contacts first.\n");
                return;
            }

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            ContactNode temp = head;
            while (temp != null)
            {
                if (temp.Data._FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    temp.Data._LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter new details");

                    Console.Write("Address: ");
                    temp.Data._Address = Console.ReadLine();

                    Console.Write("City: ");
                    temp.Data._City = Console.ReadLine();

                    Console.Write("State: ");
                    temp.Data._State = Console.ReadLine();

                    Console.Write("Zip: ");
                    temp.Data._Zip = Console.ReadLine();

                    Console.Write("Phone Number: ");
                    temp.Data._PhoneNumber = Console.ReadLine();

                    Console.Write("Email: ");
                    temp.Data._Email = Console.ReadLine();

                    Console.WriteLine("Contact updated successfully.\n");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Contact not found.\n");
        }

        // method to delete contact using name(Stack)
        public void DeleteContact()
        {
            if (head == null)
            {
                Console.WriteLine("No contacts available.\n");
                return;
            }

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            ContactNode temp = head, prev = null;

            while (temp != null)
            {
                if (temp.Data._FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    temp.Data._LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    // Push to undo stack
                    undoStack.Push(temp.Data);

                    if (prev == null)
                        head = temp.Next;
                    else
                        prev.Next = temp.Next;

                    count--;
                    Console.WriteLine("Contact deleted successfully.\n");
                    return;
                }

                prev = temp;
                temp = temp.Next;
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
                return null;

            ContactNode temp = head;
            int i = 0;

            while (temp != null)
            {
                if (i == index)
                    return temp.Data;
                i++;
                temp = temp.Next;
            }
            return null;
        }

        //method for sorting contacts by the name
        public void SortContacts()
        {
            if (count < 2)
            {
                Console.WriteLine("Not enough contacts to sort.\n");
                return;
            }

            for (int i = 0; i < count - 1; i++)
            {
                ContactNode current = head;
                ContactNode next = head.Next;

                while (next != null)
                {
                    string name1 = current.Data._FirstName + current.Data._LastName;
                    string name2 = next.Data._FirstName + next.Data._LastName;

                    if (string.Compare(name1, name2, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        AddressBook temp = current.Data;
                        current.Data = next.Data;
                        next.Data = temp;
                    }

                    current = next;
                    next = next.Next;
                }
            }

            Console.WriteLine("\nContacts sorted alphabetically.\n");
            DisplayContacts();
        }

    }
}
