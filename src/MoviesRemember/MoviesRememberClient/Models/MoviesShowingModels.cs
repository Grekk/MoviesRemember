using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesRememberDomain;

namespace MoviesRememberClient.Models
{
    public class MoviesResultModel
    {
        public MoviesResultModel()
        {
        }

        public IList<TinyMovie> MoviesList { get; set; }
    }
}