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
    }
}
