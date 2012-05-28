using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesRememberServices.Interface;
using MoviesRememberDomain;
using System.Web.Script.Serialization;
using System.Net;
using MoviesRememberServices.Utils;

namespace MoviesRememberServices
{
    public class MoviesShowingService : IMoviesShowingService
    {
        public JavaScriptSerializer _jss { get; set; }

        public MoviesShowingService()
        {
            _jss = new JavaScriptSerializer();
            _jss.RegisterConverters(new JavaScriptConverter[] { new DynamicJsonConverter() });
        }

        public TinyMovieList GetTopRankedMovies()
        {
            TinyMovieList result = new TinyMovieList();

            string json = JsonUtils.GetJson(Properties.Resources.TOP_RANKED_MOVIES_COMING_SOON);
            dynamic glossaryEntry = _jss.Deserialize(json, typeof(object)) as dynamic;

            TinyMovie movie = null;
            foreach (dynamic value in glossaryEntry.feed.movie)
            {
                movie = JsonUtils.GetTinyMovie(value);
                result.TinyMovies.Add(movie);
            }

            return result;
        }
    }
}
