using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesRememberServices.Interface;
using MoviesRememberDomain;
using MoviesRememberClient.Models;

namespace MoviesRememberClient.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpPost]
        [Authorize]
        public ActionResult Search(SearchModels model)
        {
            model.TinyMovieList = _searchService.Search(model.Query);
            return View("Search", model);
        }
    }
}