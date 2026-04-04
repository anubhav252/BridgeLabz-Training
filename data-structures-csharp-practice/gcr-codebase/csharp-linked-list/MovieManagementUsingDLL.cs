using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManAgementUsingDLL
{
 
    class MovieNode
    {
        public string Title;
        public string Director;
        public int ReleaseYear;
        public double Rating;
        public MovieNode Next;
        public MovieNode Previous;
    
        public MovieNode(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            ReleaseYear = year;
            Rating = rating;
            Next = null;
            Previous = null;
        }
    }
    
    class MovieUtility
    {
        private MovieNode head;
        private MovieNode tail;
    
        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
    
            if (head == null)
            {
                head = tail = newNode;
                return;
            }
    
            newNode.Next = head;
            head.Previous = newNode;
            head = newNode;
        }
    
        public void AddAtEnd(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
    
            if (tail == null)
            {
                head = tail = newNode;
                return;
            }
    
            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }
    
        public void AddAtPosition(string title, string director, int year, double rating, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(title, director, year, rating);
                return;
            }
    
            MovieNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }
    
            if (temp == null || temp.Next == null)
            {
                AddAtEnd(title, director, year, rating);
                return;
            }
    
            MovieNode newNode = new MovieNode(title, director, year, rating);
            newNode.Next = temp.Next;
            newNode.Previous = temp;
            temp.Next.Previous = newNode;
            temp.Next = newNode;
        }
    
        public void RemoveByTitle(string title)
        {
            MovieNode temp = head;
    
            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (temp == head)
                        head = temp.Next;
    
                    if (temp == tail)
                        tail = temp.Previous;
    
                    if (temp.Previous != null)
                        temp.Previous.Next = temp.Next;
    
                    if (temp.Next != null)
                        temp.Next.Previous = temp.Previous;
    
                    Console.WriteLine("Movie removed successfully");
                    return;
                }
                temp = temp.Next;
            }
    
            Console.WriteLine("Movie not found");
        }
    
        public void SearchByDirector(string director)
        {
            MovieNode temp = head;
            bool found = false;
    
            while (temp != null)
            {
                if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }
    
            if (!found)
                Console.WriteLine("No movies found for this director");
        }
    
        public void SearchByRating(double rating)
        {
            MovieNode temp = head;
            bool found = false;
    
            while (temp != null)
            {
                if (temp.Rating >= rating)
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }
    
            if (!found)
                Console.WriteLine("No movies found with this rating");
        }
    
        public void UpdateRating(string title, double newRating)
        {
            MovieNode temp = head;
    
            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    temp.Rating = newRating;
                    Console.WriteLine("Rating updated successfully");
                    return;
                }
                temp = temp.Next;
            }
    
            Console.WriteLine("Movie not found");
        }
    
        public void DisplayForward()
        {
            MovieNode temp = head;
    
            if (temp == null)
            {
                Console.WriteLine("No movie records available");
                return;
            }
    
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.Next;
            }
        }
    
        public void DisplayReverse()
        {
            MovieNode temp = tail;
    
            if (temp == null)
            {
                Console.WriteLine("No movie records available");
                return;
            }
    
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.Previous;
            }
        }
    
        private void DisplayMovie(MovieNode movie)
        {
            Console.WriteLine(
                "Title: " + movie.Title +
                ", Director: " + movie.Director +
                ", Year: " + movie.ReleaseYear +
                ", Rating: " + movie.Rating
            );
        }
    }
    
    class MovieMain
    {
        static void Main(string[] args)
        {
            MovieUtility movies = new MovieUtility();
    
            movies.AddAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
            movies.AddAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);
            movies.AddAtBeginning("The Matrix", "Wachowski", 1999, 8.7);
            movies.AddAtPosition("Avatar", "James Cameron", 2009, 7.9, 2);
    
            Console.WriteLine("All Movies (Forward):");
            movies.DisplayForward();
    
            Console.WriteLine("\nAll Movies (Reverse):");
            movies.DisplayReverse();
    
            Console.WriteLine("\nSearch by Director:");
            movies.SearchByDirector("Christopher Nolan");
    
            Console.WriteLine("\nSearch by Rating >= 8.7:");
            movies.SearchByRating(8.7);
    
            Console.WriteLine("\nUpdate Rating:");
            movies.UpdateRating("Avatar", 8.1);
    
            Console.WriteLine("\nRemove Movie:");
            movies.RemoveByTitle("The Matrix");
    
            Console.WriteLine("\nFinal Movie List:");
            movies.DisplayForward();
        }
    }
}


