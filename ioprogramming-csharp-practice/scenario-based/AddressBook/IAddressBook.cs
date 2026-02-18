using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal interface IAddressBook
    {
        void AddContact();
        void DisplayContacts();
        void EditContact();// for Editing contacts
        void DeleteContact();// for deleting contact
        void AddMultipleContact();// for adding multiple contacts
        void SortContacts();// for sorting contacts
        void SortByCity();//for sorting by city
        void SortByState();// for sorting by state
        void SortByZip();//for sorting by zip
        void WriteToFile();//for writing file
        void ReadFromFile();//for reading file
    }
}
