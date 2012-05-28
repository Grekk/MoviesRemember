using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesRememberDomain;

namespace MoviesRememberServices.Interface
{
    public interface IMoviesShowingService
    {
        TinyMovieList GetNowShowingMovies();

        TinyMovieList GetComingSoonMovies();
    }
}
