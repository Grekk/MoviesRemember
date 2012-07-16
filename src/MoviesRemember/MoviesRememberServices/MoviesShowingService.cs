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

        private const int COUNT = 24;

        public MoviesShowingService(IMovieBuilder movieBuilder)
        {
            _jss = new JavaScriptSerializer();
            _jss.RegisterConverters(new JavaScriptConverter[] { new DynamicJsonConverter() });
            _movieBuilder = movieBuilder;
        }

        public TinyMovieList GetNowShowingMoviesByRate(int numPage)
        {
            TinyMovieList result = new TinyMovieList();

            string json = JsonUtils.GetJson(Properties.Resources.TOP_RANKED_MOVIES_NOW_SHOWING + numPage);
            dynamic glossaryEntry = _jss.Deserialize(json, typeof(object)) as dynamic;
            result.TinyMovies.Count = COUNT;

            TinyMovie movie = null;
            foreach (dynamic value in glossaryEntry.feed.movie)
            {
                movie = _movieBuilder.BuildTinyMovie(value);
                result.TinyMovies.EntityList.Add(movie);
            }

            SetPaging(result, glossaryEntry.feed);

            return result;
        }

        public TinyMovieList GetNowShowingMoviesByDate(int numPage)
        {
            TinyMovieList result = new TinyMovieList();

            string json = JsonUtils.GetJson(Properties.Resources.ORDER_BY_DATE_MOVIES_NOW_SHOWING + numPage);
            dynamic glossaryEntry = _jss.Deserialize(json, typeof(object)) as dynamic;
            result.TinyMovies.Count = COUNT;

            TinyMovie movie = null;
            foreach (dynamic value in glossaryEntry.feed.movie)
            {
                movie = _movieBuilder.BuildTinyMovie(value);
                result.TinyMovies.EntityList.Add(movie);
            }
            
            SetPaging(result, glossaryEntry.feed);

            result.TinyMovies.EntityList = result.TinyMovies.EntityList.OrderByDescending(x => x.ReleaseDate).ToList();

            return result;
        }

        public TinyMovieList GetComingSoonMoviesByRate(int numPage)
        {
            TinyMovieList result = new TinyMovieList();

            string json = JsonUtils.GetJson(Properties.Resources.TOP_RANKED_MOVIES_COMING_SOON + numPage);
            dynamic glossaryEntry = _jss.Deserialize(json, typeof(object)) as dynamic;
            result.TinyMovies.Count = COUNT;

            TinyMovie movie = null;
            foreach (dynamic value in glossaryEntry.feed.movie)
            {
                movie = _movieBuilder.BuildTinyMovie(value);
                result.TinyMovies.EntityList.Add(movie);
            }

            SetPaging(result, glossaryEntry.feed);

            return result;
        }

        public TinyMovieList GetComingSoonMoviesByDate(int numPage)
        {
            TinyMovieList result = new TinyMovieList();

            string json = JsonUtils.GetJson(Properties.Resources.ORDER_BY_DATE_MOVIES_COMING_SOON + numPage);
            dynamic glossaryEntry = _jss.Deserialize(json, typeof(object)) as dynamic;
            result.TinyMovies.Count = COUNT;
            TinyMovie movie = null;
            foreach (dynamic value in glossaryEntry.feed.movie)
            {
                movie = _movieBuilder.BuildTinyMovie(value);
                result.TinyMovies.EntityList.Add(movie);
            }
            result.TinyMovies.EntityList = result.TinyMovies.EntityList.OrderBy(x => x.ReleaseDate).ToList();
            SetPaging(result, glossaryEntry.feed);

            return result;
        }

        public Movie GetMovie(long code)
        {
            string json = JsonUtils.GetJson(Properties.Resources.DISPLAY_MOVIE_URL+"&code=" + code);
            dynamic glossaryEntry = _jss.Deserialize(json, typeof(object)) as dynamic;
            return _movieBuilder.BuildMovie(glossaryEntry.movie);
        }

        private void SetPaging(TinyMovieList movieList, dynamic feed)
        {
            movieList.TinyMovies.TotalResult = (int)feed.totalResults;
            movieList.TinyMovies.TotalPage = movieList.TinyMovies.TotalResult / movieList.TinyMovies.Count;

            if(movieList.TinyMovies.Count * movieList.TinyMovies.TotalPage != movieList.TinyMovies.TotalResult)
            {
                movieList.TinyMovies.TotalPage++;
            }
        }
    }
}
