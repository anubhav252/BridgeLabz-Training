namespace AddressBookSystem
{
    internal class ContactNode
    {
        public AddressBook Data;
        public ContactNode Next;

        public ContactNode(AddressBook data)
        {
            Data = data;
            Next = null;
        }
    }
}
