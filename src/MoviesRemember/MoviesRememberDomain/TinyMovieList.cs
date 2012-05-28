using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesRememberDomain
{
    public class TinyMovieList
    {
        public TinyMovieList()
        {
            TinyMovies = new List<TinyMovie>();
        }

        public int Page { get; set; }
        public int Count { get; set; }
        public int TotalResult { get; set; }

        public IList<TinyMovie> TinyMovies { get; set; }
    }
}
