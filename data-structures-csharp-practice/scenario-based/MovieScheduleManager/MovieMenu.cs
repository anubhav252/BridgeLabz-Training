using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class MovieMenu
    {
        Movie[] movies;

        IMovie utility = new MovieUtility();
        public void Menu()
        {

            Console.WriteLine("Enter your choice :");
            while (true)
            {
                Console.WriteLine("1.Add Movies \n2.SearchMovie \n3.Display Movies \n4.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        movies = utility.AddMovie();
                        break;
                    case 2:
                        utility.SearchMovie(movies);
                        break;
                    case 3:
                        utility.DisplayAllMovies(movies);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("invalid choice! Enter again :");
                        break;
                }
            }
        }
    }

    
}
