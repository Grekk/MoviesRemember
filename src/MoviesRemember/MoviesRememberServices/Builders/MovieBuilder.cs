using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesRememberDomain;

namespace MoviesRememberServices.Builders
{
    public class MovieBuilder : IMovieBuilder
    {
        public TinyMovie BuildTinyMovie(dynamic jsonData)
        {

            TinyMovie movie = new TinyMovie();
            movie.Id = BuildProperty(jsonData, "code");
            movie.PictureUrl = BuildProperty(jsonData, "poster", "href");
            movie.Title = BuildProperty(jsonData, "title");
            movie.OriginalTitle = BuildProperty(jsonData, "originalTitle");
            movie.PressRatings = BuildProperty(jsonData, "statistics", "pressRating");
            movie.UserRatings = BuildProperty(jsonData, "statistics", "userRating");
            movie.Actors = BuildProperty(jsonData, "castingShort", "actors");
            movie.Director = BuildProperty(jsonData, "castingShort", "directors");
            movie.Trailer = BuildProperty(jsonData,"trailer","href");

            return movie;
        }

        private dynamic BuildProperty(dynamic jsonData, string firstKey, string secondKey)
        {
            dynamic result = null;
            try
            {
                result = (jsonData[firstKey])[secondKey];
            }
            catch
            {
            }

            return result;
        }

        private dynamic BuildProperty(dynamic jsonData, string firstKey)
        {
            dynamic result = null;
            try
            {
                result = jsonData[firstKey];
            }
            catch
            {
            }

            return result;
        }
    }
}
