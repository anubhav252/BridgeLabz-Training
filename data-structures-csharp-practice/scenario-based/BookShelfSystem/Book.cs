namespace BookShelf
{
    internal class Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}";
        }
    }
}
