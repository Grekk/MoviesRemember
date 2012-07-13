using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesRememberDomain;

namespace MoviesRememberServices.Interface
{
    public interface IUserService
    {
        void AddMovie(Guid userId, string userName, Movie movie);

        void DeleteMovie (long id);

        void UpdateMovie(UserMovie movie);

        IList<UserMovie> GetUserMovieList(Guid userId);

        IList<UserAction> AddUserAction(UserAction action);

        IList<UserAction> GetUsersActions();
    }
}
