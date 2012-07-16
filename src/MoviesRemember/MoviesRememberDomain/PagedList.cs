using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesRememberDomain
{
    public class PagedList<T>
    {
        public PagedList()
        {
            EntityList = new List<T>();
            Page = 1;
            TotalResult = 0;
            TotalPage = 1;
        }

        public IList<T> EntityList { get; set; }

        public bool HasPreviousPage
        {
            get
            {
                return Page > 1;
            }
        }

        public bool HasNextPage
        {
            get
            {
                return Page + 1 <= TotalPage;
            }
        }

        public int Page { get; set; }
        public int Count { get; set; }
        public int TotalResult { get; set; }
        public int TotalPage { get; set; }
    }
}
