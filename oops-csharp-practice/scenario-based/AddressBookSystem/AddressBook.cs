using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        // encapsulated class for contacts
        private string FirstName { get; }
        private string LastName { get; }
        private string Address { get; }
        private string City { get; }
        private string State { get; }
        private string Zip { get; }
        private string PhoneNumber { get; }
        private string Email { get; }

        public AddressBook(string firstName,string lastName,string address,string city,string state,string zip,string phoneNumber,string email){
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\n" +
                   $"Address: {Address}, {City}, {State} - {Zip}\n" +
                   $"Phone: {PhoneNumber}\n" +
                   $"Email: {Email}";
        }
    }
}
