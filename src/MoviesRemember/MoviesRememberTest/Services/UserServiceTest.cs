using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesRememberDB;
using MoviesRememberDao.Interface;
using MoviesRememberServices;
using MoviesRememberServices.Interface;
using NUnit.Framework;
using MoviesRememberServices.Utils;
using MoviesRememberDao;
using FluentAssertions;
using MoviesRememberDomain;
using StructureMap;
using Action = MoviesRememberDomain.Action;
using ServiceStack.Redis;

namespace MoviesRememberTest.Services
{
    [TestFixture]
    public class UserServiceTest
    {
        private IUserService _userService;

        public UserServiceTest()
        {
            Bootstrapper.Bootstrap();
            _userService = ObjectFactory.GetInstance<IUserService>();
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
        public void AddActionTest()
        {
            IList<UserAction> actionList = new List<UserAction>();

            for (int i = 1; i < UserService.UserActionsLength; i++)
            {
                UserAction action = new UserAction()
                {
                    Action = Action.ADD_MOVIE,
                    UserName = i.ToString(),
                    MovieName = "Le huitieme jour"
                };

                actionList = _userService.AddUserAction(action);
            }

            actionList.Count.Should().Be(UserService.UserActionsLength - 1);

            actionList[0].UserName.Should().Be((UserService.UserActionsLength - 1).ToString());
            actionList[UserService.UserActionsLength - 2].UserName.Should().Be("1");

            UserAction lastAction = new UserAction
            {
                Action = Action.ADD_MOVIE,
                UserName = UserService.UserActionsLength.ToString(),
                MovieName = "Le huitieme jour"
            };

            actionList = _userService.AddUserAction(lastAction);
            actionList[0].UserName.Should().Be((UserService.UserActionsLength).ToString());
            actionList[UserService.UserActionsLength - 2].UserName.Should().Be("2");
        }

    }
}
