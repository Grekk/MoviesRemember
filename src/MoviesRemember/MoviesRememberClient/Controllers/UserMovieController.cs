using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesRememberServices.Interface;
using System.Web.Security;
using MoviesRememberDomain;

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
        public ActionResult UpdateUserMovie(UserMovie userMovie)
        {
            if(userMovie.Delete)
            {
                _userService.DeleteMovie(userMovie.Id);
            }
            else
            {
                _userService.UpdateMovie(userMovie);
            }

            return RedirectToAction("MyList");
        }
    }
}