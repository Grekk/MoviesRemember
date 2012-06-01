using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesRememberServices.Interface;
using MoviesRememberDomain;
using AutoMapper;
using DefaultConnection;
using MoviesRememberDao;
using MoviesRememberDao.Interface;

namespace MoviesRememberServices
{
    public class UserService : IUserService
    {
        private readonly AbstractUserMovieDAO _userMovieRepo;

        public UserService(AbstractUserMovieDAO userMovieRepo)
        {
            _userMovieRepo = userMovieRepo;
        }

        public void AddMovie(Guid userId, Movie movie)
        {
            TinyMovie tinyMovie = (TinyMovie)movie;
            user_movie userMovie = Mapper.Map<TinyMovie, user_movie>(tinyMovie);
            userMovie.user_movie_user_id = userId;

            _userMovieRepo.Insert(userMovie);
        }

        public TinyMovieList GetUserMovieList(Guid userId)
        {
            IList<user_movie> dbResult = _userMovieRepo.GetByUserId(userId);

            TinyMovieList result = new TinyMovieList();
            result.TinyMovies = Mapper.Map<IList<user_movie>, IList<TinyMovie>>(dbResult);

            return result;
        }
    }
}
