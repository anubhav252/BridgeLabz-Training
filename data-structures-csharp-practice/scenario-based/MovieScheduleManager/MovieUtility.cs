using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class MovieUtility : IMovie
        {
            public Movie[] AddMovie()
            {
                Console.WriteLine("Enter no. of Shows :");
                int numberOfShows = int.Parse(Console.ReadLine());
                Movie[] movies = new Movie[numberOfShows];
                for (int i = 0; i < numberOfShows; i++)
                {
                    Console.WriteLine("Enter Movie Title :");
                    string titleInput = Console.ReadLine();
                    Console.WriteLine("Enter ShowTime :");
                    string showTimeInput = Console.ReadLine();
                    Console.WriteLine("Enter Movie Description :");
                    string descriptionInput = Console.ReadLine();
                    movies[i] = new Movie(titleInput, showTimeInput, descriptionInput);
                }
                return movies;
            }

            public void SearchMovie(Movie[] movies)
            {
                if (movies == null || movies.Length == 0)
                {
                    Console.WriteLine("no data ! \n---Add Movies first---");
                    return;
                }
                Console.WriteLine("Enter movie title here :");
                string titleInput = Console.ReadLine();
                for (int i = 0; i < movies.Length; i++)
                {
                    if (movies[i].Title.Contains(titleInput, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(movies[i].Title + " / " + movies[i].ShowTime + " / " + movies[i].Description);
                        return;
                    }
                }
                Console.WriteLine("Movie does not exist");
            }

            public void DisplayAllMovies(Movie[] movies)
            {
                if (movies == null || movies.Length == 0)
                {
                    Console.WriteLine("no data ! \n---Add Movies first---");
                    return;
                }
                for (int i = 0; i < movies.Length; i++)
                {
                    Console.WriteLine(movies[i].Title + " / " + movies[i].ShowTime + " / " + movies[i].Description);
                }
            }
        }  
}
