using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesRememberServices.Interface;
using Quartz;
using StructureMap;
using SharpBrake;

namespace MoviesRememberServices.Utils
{
    public class AlertMovieJob : IJob
    {
        public AlertMovieJob()
        {
        }

        public void Execute(IJobExecutionContext context)
        {
            new Exception("Execute Job").SendToAirbrake();
            IUserService userService = ObjectFactory.GetInstance<IUserService>();
            userService.SendMoviesReleased();
        }
    }
}
