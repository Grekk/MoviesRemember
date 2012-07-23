using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesRememberServices.Interface;
using System.Web.Security;
using MoviesRememberDomain;
using MoviesRememberServices.Utils;

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
        public ActionResult MyList()
        {
            IList<UserMovie> model = _userService.GetUserMovieList((Guid)Membership.GetUser().ProviderUserKey);
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