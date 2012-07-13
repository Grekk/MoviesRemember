using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesRememberDomain
{
    public class UserAction
    {
        public string UserName { get; set; }
        public Action Action { get; set; }
        public string ActionLabel { get; set; }
    }

    public enum Action
    {
        ADD_MOVIE,
        DELETE_MOVIE,
        SHOW_MOVIE
    }
}
