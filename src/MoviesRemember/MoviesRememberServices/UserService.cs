using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesRememberServices.Interface;
using MoviesRememberDomain;
using AutoMapper;
using MoviesRememberDao;
using MoviesRememberDao.Interface;
using MoviesRememberDB;
using MoviesRememberServices.Utils;
using Action = MoviesRememberDomain.Action;

namespace MoviesRememberServices
{
    public class UserService : IUserService
    {
        private readonly AbstractUserMovieDAO _userMovieRepo;
        private readonly IUserActionsDAO _userActionDAO;

        public const int UserActionsLength = 50;


        public UserService(IUserActionsDAO userActionDAO, AbstractUserMovieDAO userMovieRepo)
        {
            _userMovieRepo = userMovieRepo;
            _userActionDAO = userActionDAO;
        }

        public void AddMovie(Guid userId, string userName, Movie movie)
        {
            TinyMovie tinyMovie = (TinyMovie)movie;
            user_movie userMovie = Mapper.Map<TinyMovie, user_movie>(tinyMovie);
            userMovie.user_movie_user_id = userId;

            _userMovieRepo.Insert(userMovie);

            UserAction actionToAdd = new UserAction(userName, movie);
            actionToAdd.Action = Action.ADD_MOVIE;
            AddUserAction(actionToAdd);
        }

        public void DeleteMovie(string userName, UserMovie movie)
        {
            _userMovieRepo.DeleteById(movie.Id);

            UserAction actionToAdd = new UserAction(userName, movie);
            actionToAdd.Action = Action.DELETE_MOVIE;
            AddUserAction(actionToAdd);
        }

        public void UpdateMovie(UserMovie userMovie)
        {
            user_movie userMovieToUpdate = Mapper.Map<UserMovie, user_movie>(userMovie);
            _userMovieRepo.Update(userMovieToUpdate);
        }

        public IList<UserMovie> GetUserMovieList(Guid userId)
        {
            IList<UserMovie> result = new List<UserMovie>();
            IList<user_movie> dbResult = _userMovieRepo.GetByUserId(userId);
            foreach (user_movie movie in dbResult)
            {
                result.Add(Mapper.Map<user_movie, UserMovie>(movie));
            }

            return result;
        }

        public IList<UserAction> AddUserAction(UserAction action)
        {
            IList<UserAction> userActions = new List<UserAction>();

            try
            {
                userActions = _userActionDAO.AddActionAtFirstIndex(action);
                if (userActions.Count == UserActionsLength)
                {
                    userActions = _userActionDAO.RemoveLastAction();
                }

                return userActions;
            }
            catch (Exception ex)
            {
                new LogEvent(ex.Message).Raise();
            }

            return userActions;
        }

        public IList<UserAction> GetUsersActions()
        {
            return _userActionDAO.GetActions();
        }
    }
}
