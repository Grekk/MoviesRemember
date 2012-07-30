using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesRememberClient.MoviesShowingService;

namespace MoviesRememberClient.Models
{
    public class SearchModels
    {
        public string Query { get; set; }

        public TinyMovieList TinyMovieList { get; set; }
    }
}