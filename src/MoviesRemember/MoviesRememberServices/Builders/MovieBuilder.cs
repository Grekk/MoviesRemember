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
            movie.ApiId = BuildProperty(jsonData, "code");
            movie.PictureUrl = BuildProperty(jsonData, "poster", "href");
            movie.Title = BuildProperty(jsonData, "title");
            movie.OriginalTitle = BuildProperty(jsonData, "originalTitle");
            movie.PressRatings = BuildProperty(jsonData, "statistics", "pressRating");
            movie.UserRatings = BuildProperty(jsonData, "statistics", "userRating");
            movie.Actors = BuildProperty(jsonData, "castingShort", "actors");
            movie.Director = BuildProperty(jsonData, "castingShort", "directors");
            movie.ReleaseDate = BuildProperty(jsonData, "release", "releaseDate");
            movie.Trailer = BuildProperty(jsonData,"trailer","href");

            return movie;
        }

        public Movie BuildMovie(dynamic jsonData)
        {
            Movie movie = new Movie();
            movie.ApiId = jsonData.code;
            movie.PictureUrl = jsonData.poster.href;
            movie.Title = jsonData.title;
            movie.OriginalTitle = jsonData.originalTitle;
            movie.Actors = jsonData.castingShort.actors;
            movie.Director = jsonData.castingShort.directors;
            movie.ReleaseDate = jsonData.release.releaseDate;
            movie.Trailer = BuildProperty(jsonData.trailer, "href");
            movie.LinkList = BuildLink(jsonData.link);

            try { movie.PressRatings = jsonData.statistics.pressRating; }
            catch { movie.PressRatings = null; }

            try { movie.UserRatings = jsonData.statistics.userRating; }
            catch { movie.UserRatings = null; }

            try { movie.Synopsis = jsonData.synopsis; }
            catch { movie.Synopsis = null; }

            return movie;
        }

        public IList<Link> BuildLink(dynamic jsonData)
        {
            IList<Link> result = new List<Link>();
            try
            {
                foreach (dynamic item in jsonData)
                {
                    result.Add(new Link() { Name = item["name"], Href = item["href"] });
                }
            }
            catch
            {
            }

            return result;
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
