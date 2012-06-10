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

        public TinyMovieList GetNowShowingMoviesByRate()
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

        public TinyMovieList GetNowShowingMoviesByDate()
        {
            TinyMovieList result = new TinyMovieList();

            string json = JsonUtils.GetJson(Properties.Resources.ORDER_BY_DATE_MOVIES_NOW_SHOWING);
            dynamic glossaryEntry = _jss.Deserialize(json, typeof(object)) as dynamic;

            TinyMovie movie = null;
            foreach (dynamic value in glossaryEntry.feed.movie)
            {
                movie = _movieBuilder.BuildTinyMovie(value);
                result.TinyMovies.Add(movie);
            }
            result.TinyMovies = result.TinyMovies.OrderByDescending(x => x.ReleaseDate).ToList();

            return result;
        }

        public TinyMovieList GetComingSoonMoviesByRate()
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

        public TinyMovieList GetComingSoonMoviesByDate()
        {
            TinyMovieList result = new TinyMovieList();

            string json = JsonUtils.GetJson(Properties.Resources.ORDER_BY_DATE_MOVIES_COMING_SOON);
            dynamic glossaryEntry = _jss.Deserialize(json, typeof(object)) as dynamic;

            TinyMovie movie = null;
            foreach (dynamic value in glossaryEntry.feed.movie)
            {
                movie = _movieBuilder.BuildTinyMovie(value);
                result.TinyMovies.Add(movie);
            }
            result.TinyMovies = result.TinyMovies.OrderBy(x => x.ReleaseDate).ToList();

            return result;
        }

        public Movie GetMovie(long code)
        {
            string json = JsonUtils.GetJson(Properties.Resources.DISPLAY_MOVIE_URL+"&code=" + code);
            dynamic glossaryEntry = _jss.Deserialize(json, typeof(object)) as dynamic;
            return _movieBuilder.BuildMovie(glossaryEntry.movie);
        }
    }
}
