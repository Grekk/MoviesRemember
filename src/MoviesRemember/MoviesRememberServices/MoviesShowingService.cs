using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesRememberServices.Interface;
using MoviesRememberDomain;
using System.Web.Script.Serialization;
using System.Net;
using MoviesRememberServices.Utils;
using MoviesRememberServices.Builders;

namespace MoviesRememberServices
{
    public class MoviesShowingService : IMoviesShowingService
    {
        private JavaScriptSerializer _jss;
        private readonly IMovieBuilder _movieBuilder;
        

        public MoviesShowingService(IMovieBuilder movieBuilder)
        {
            _jss = new JavaScriptSerializer();
            _jss.RegisterConverters(new JavaScriptConverter[] { new DynamicJsonConverter() });
            _movieBuilder = movieBuilder;
        }

        public TinyMovieList GetNowShowingMovies()
        {
            TinyMovieList result = new TinyMovieList();

            string json = JsonUtils.GetJson(Properties.Resources.TOP_RANKED_MOVIES_NOW_SHOWING);
            dynamic glossaryEntry = _jss.Deserialize(json, typeof(object)) as dynamic;

            TinyMovie movie = null;
            foreach (dynamic value in glossaryEntry.feed.movie)
            {
                movie = _movieBuilder.BuildTinyMovie(value);
                result.TinyMovies.Add(movie);
            }

            return result;
        }

        public TinyMovieList GetComingSoonMovies()
        {
            TinyMovieList result = new TinyMovieList();

            string json = JsonUtils.GetJson(Properties.Resources.TOP_RANKED_MOVIES_COMING_SOON);
            dynamic glossaryEntry = _jss.Deserialize(json, typeof(object)) as dynamic;

            TinyMovie movie = null;
            foreach (dynamic value in glossaryEntry.feed.movie)
            {
                movie = _movieBuilder.BuildTinyMovie(value);
                result.TinyMovies.Add(movie);
            }

            return result;
        }
    }
}
