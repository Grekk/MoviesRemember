using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesRememberDB;
using MoviesRememberDao.Interface;
using NUnit.Framework;
using MoviesRememberServices.Utils;
using MoviesRememberDao;
using FluentAssertions;
using MoviesRememberDomain;
using StructureMap;
using Action = MoviesRememberDomain.Action;
using ServiceStack.Redis;

namespace MoviesRememberTest.DAO
{
    [TestFixture]
    public class UserActionsDAOTest
    {
        private IUserActionsDAO _userActionsDAO;
        private AbstractUserMovieDAO _userMovieDAO;
        private PetaPoco.Database _db;


        public UserActionsDAOTest()
        {
            Bootstrapper.Bootstrap();
            _db = ObjectFactory.GetInstance<PetaPoco.Database>();
            _userMovieDAO = ObjectFactory.GetInstance<UserMovieDAO>();
            _userActionsDAO = ObjectFactory.GetInstance<IUserActionsDAO>();
        }

        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
            using (var redis = ObjectFactory.GetInstance<IRedisClient>())
            {
                redis.FlushAll();
            }
        }

        [Test]
        public void GetUserActionsTest()
        {
            IList<UserAction> result = _userActionsDAO.GetActions();
            result.Count.Should().Be(0);
        }

        [Test]
        public void AddAndRemoveUserActionTest()
        {
            // arrange
            UserAction actionFirst = new UserAction()
            {
                Action = Action.ADD_MOVIE,
                UserName = "1",
                MovieName = "Le huitieme jour"
            };

            // arrange
            UserAction actionSecond = new UserAction()
            {
                Action = Action.ADD_MOVIE,
                UserName = "2",
                MovieName = "Le huitieme jour"
            };

            // act
            _userActionsDAO.AddActionAtFirstIndex(actionFirst);
            _userActionsDAO.AddActionAtFirstIndex(actionSecond);

            // assert
            IList<UserAction> result = _userActionsDAO.GetActions();
            result.Count.Should().Be(2);
            result[0].Action.Should().Be(actionSecond.Action);
            result[0].MovieName.Should().Be(actionSecond.MovieName);
            result[0].UserName.Should().Be(actionSecond.UserName);

            result[1].Action.Should().Be(actionFirst.Action);
            result[1].MovieName.Should().Be(actionFirst.MovieName);
            result[1].UserName.Should().Be(actionFirst.UserName);

            _userActionsDAO.RemoveLastAction();
            // assert
            result = _userActionsDAO.GetActions();
            result.Count.Should().Be(1);
            result[0].Action.Should().Be(actionSecond.Action);
            result[0].MovieName.Should().Be(actionSecond.MovieName);
            result[0].UserName.Should().Be(actionSecond.UserName);
        }

    }
}
