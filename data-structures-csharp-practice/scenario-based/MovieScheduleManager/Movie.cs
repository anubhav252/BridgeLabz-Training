using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    internal class Movie
    {
        private string MovieTitle;
        private string MovieShowTime;
        private string MovieDescription;

        public string Title
        {
            get
            {
                return MovieTitle;
            }
        }
        public string ShowTime
        {
            get
            {
                return MovieShowTime;
            }
        }
        public string Description
        {
            get
            {
                return MovieDescription;
            }
        }

        public Movie(string movieTitle, string movieShowTime, string movieDescription)
        {
            MovieTitle = movieTitle;
            MovieShowTime = movieShowTime;
            MovieDescription = movieDescription;
        }
    }
}
