using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesRememberClient.MoviesShowingService;
using MoviesRememberClient.Models;

namespace MoviesRememberClient.Controllers
{
    public class SearchController : Controller
    {
        private readonly IMoviesShowingService _moviesShowingService;

        public SearchController(IMoviesShowingService moviesShowingService)
        {
            _moviesShowingService = moviesShowingService;
        }

        [HttpPost]
        [Authorize]
        public ActionResult Search(string q)
        {
            TinyMovieList movieList = _moviesShowingService.Search(q);
            return View("Search", movieList);
        }
    }
}