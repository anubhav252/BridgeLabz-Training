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
        private string FirstName;
        private string LastName;
        private string Address;
        private string City;
        private string State;
        private string Zip;
        private string PhoneNumber;
        private string Email;

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

        public string _FirstName
        {
            get { return FirstName; }
            set
            {
                FirstName = value;
            }
        }
        public string _LastName
        {
            get { return LastName; }
            set { 
                LastName = value;
            }
        }
        public string _Address
        {
            get { return Address; }
            set { Address = value; }
        }
        public string _City
        {
            get { return City; }
            set { City = value; }
        }
        public string _State
        {
            get { return State; }
            set { State = value; }
        }
        public string _Zip
        {
            get { return Zip; }
            set { Zip = value; }
        }
        public string _PhoneNumber
        {
            get { return  PhoneNumber; }
            set { PhoneNumber = value; }
        }
        public string _Email
        {
            get { return  Email; }
            set { Email = value; }
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
