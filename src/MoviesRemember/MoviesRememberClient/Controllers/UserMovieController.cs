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
            TinyMovieList model = _userService.GetUserMovieList((Guid)Membership.GetUser().ProviderUserKey);
            return View(model);
        }
    }
}