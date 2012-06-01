using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesRememberDomain
{
    public class Movie : TinyMovie
    {
        public Movie()
        {
            LinkList = new List<Link>();
        }

        public IList<Link> LinkList { get; set; }

        public string Synopsis { get; set; }
    }
}
