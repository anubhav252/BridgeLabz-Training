using System;

namespace BookShelf
{
    internal class CustomHashMap
    {
        private HashMap[] buckets;
        private int size;

        public CustomHashMap(int capacity)
        {
            buckets = new HashMap[capacity];
            size = capacity;
        }

        private int GetHash(string key)
        {
            int hash = 0;
            foreach (char c in key)
                hash += c;
            return hash % size;
        }

        public void AddBook(string genre, Book book)
        {
            int index = GetHash(genre);

            if (buckets[index] == null)
            {
                buckets[index] = new HashMap(genre);
            }

            buckets[index].Books.AddBook(book);
        }

        public void RemoveBook(string genre, string title)
        {
            int index = GetHash(genre);

            if (buckets[index] != null)
            {
                buckets[index].Books.RemoveBook(title);
            }
            else
            {
                Console.WriteLine("Genre not found.");
            }
        }

        public void DisplayGenre(string genre)
        {
            int index = GetHash(genre);

            if (buckets[index] != null)
            {
                Console.WriteLine($"Genre: {genre}");
                buckets[index].Books.Display();
            }
            else
            {
                Console.WriteLine("Genre not found.");
            }
        }
    }
}
