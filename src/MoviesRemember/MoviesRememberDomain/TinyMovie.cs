using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesRememberDomain
{
    public class TinyMovie
    {
        public long Id { get; set; }

        public long ApiId { get; set; }
     
        public string PictureUrl { get; set; }

        public string Title { get; set; }

        public string OriginalTitle { get; set; }

        public string Actors { get; set; }

        public string Director { get; set; }

        public decimal? UserRatings { get; set; }

        public decimal? PressRatings { get; set; }

        public string Trailer { get; set; }

        public string ReleaseDate { get; set; }
    }
}
