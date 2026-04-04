using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MovieApp
{
    internal interface IMovie
    {
        Movie[] AddMovie();
        void SearchMovie(Movie[] movies);
        void DisplayAllMovies(Movie[] movies);
    }
}
