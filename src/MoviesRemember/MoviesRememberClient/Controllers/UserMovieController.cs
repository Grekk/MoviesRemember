using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesRememberClient.UserService;
using System.Web.Security;

namespace MoviesRememberClient.Controllers
{
    public class UserMovieController : Controller
    {
        private readonly IUserService _userService;

        public UserMovieController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize]
        public ActionResult MyList(int page = 1)
        {
            TinyUserMovieList model = _userService.GetUserMovieList((Guid)Membership.GetUser().ProviderUserKey, page);
            model.TinyUserMovies.CurrentPage = page;
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult DeleteUserMovie(UserMovie userMovie)
        {
            _userService.DeleteMovie(User.Identity.Name, userMovie);
            return RedirectToAction("MyList");
        }

        [Authorize]
        [HttpPost]
        public ActionResult UpdateUserMovie(UserMovie userMovie)
        {
            _userService.UpdateMovie(userMovie);
            return RedirectToAction("MyList");
        }
    }
}