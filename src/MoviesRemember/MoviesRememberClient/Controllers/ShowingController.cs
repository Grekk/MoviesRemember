using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesRememberServices.Interface;
using MoviesRememberDomain;
using System.Web.Security;

namespace MoviesRememberClient.Controllers
{
    public class ShowingController : Controller
    {
        private IMoviesShowingService _moviesShowingService;
        private IUserService _userService;

        public ShowingController(IMoviesShowingService moviesShowingService, IUserService userService)
        {
            _moviesShowingService = moviesShowingService;
            _userService = userService;
        }

        //
        // GET: /Showing/
        [Authorize]
        public ActionResult NowShowing(int page = 1)
        {
            TinyMovieList result = _moviesShowingService.GetNowShowingMoviesByRate(page);
            result.TinyMovies.CurrentPage = page;
            return View(result);
        }

        //
        // GET: /Showing/
        [Authorize]
        public ActionResult NowShowingByDate(int page = 1)
        {
            TinyMovieList result = _moviesShowingService.GetNowShowingMoviesByDate(page);
            result.TinyMovies.CurrentPage = page;
            return View(result);
        }

        [Authorize]
        public ActionResult ComingSoon(int page = 1)
        {
            TinyMovieList result = _moviesShowingService.GetComingSoonMoviesByRate(page);
            result.TinyMovies.CurrentPage = page;
            return View(result);
        }

        [Authorize]
        public ActionResult ComingSoonByDate(int page = 1)
        {
            TinyMovieList result = _moviesShowingService.GetComingSoonMoviesByDate(page);
            result.TinyMovies.CurrentPage = page;
            return View(result);
        }

        [Authorize]
        public ActionResult DisplayMovie(long code)
        {
            Movie result = _moviesShowingService.GetMovie(code);
            return View(result);
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddMovie(Movie movie)
        {
            _userService.AddMovie((Guid)Membership.GetUser().ProviderUserKey,User.Identity.Name, movie);
            return RedirectToAction("DisplayMovie", new { code = movie.ApiId });
        }

        public ActionResult UsersActions()
        {
            IList<UserAction> userActions = _userService.GetUsersActions().Where(x => x.UserName != User.Identity.Name).ToList();
            return View("_UsersActions", userActions);
        }
    }
}
