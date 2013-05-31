using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesRememberClient.MoviesShowingService;
using MoviesRememberClient.UserService;
using StructureMap;

namespace MoviesRememberClient.Registry
{
    public static class Bootstrapper
    {
        public static void Bootstrap()
        {
            ObjectFactory.Container.Configure(
                c => c.For<IMoviesShowingService>().Use(new MoviesShowingServiceClient())
                );

            ObjectFactory.Container.Configure(
                c => c.For<IUserService>().Use(new UserServiceClient())
                );
        }
    }
}