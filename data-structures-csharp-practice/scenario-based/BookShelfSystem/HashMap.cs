namespace BookShelf
{
    internal class HashMap
    {
        public string Genre;
        public BookLinkedList Books;

        public HashMap(string genre)
        {
            Genre = genre;
            Books = new BookLinkedList();
        }
    }
}
