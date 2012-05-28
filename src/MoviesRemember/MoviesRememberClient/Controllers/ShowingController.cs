using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesRememberServices.Interface;
using MoviesRememberDomain;

namespace MoviesRememberClient.Controllers
{
    public class ShowingController : Controller
    {
        private IMoviesShowingService _moviesShowingService;

        public ShowingController(IMoviesShowingService moviesShowingService)
        {
            _moviesShowingService = moviesShowingService;
        }

        //
        // GET: /Showing/
        public ActionResult NowShowing()
        {
            TinyMovieList result = _moviesShowingService.GetNowShowingMovies();
            return View(result);
        }

        public ActionResult ComingSoon()
        {
            TinyMovieList result = _moviesShowingService.GetComingSoonMovies();
            return View(result);
        }
    }
}
