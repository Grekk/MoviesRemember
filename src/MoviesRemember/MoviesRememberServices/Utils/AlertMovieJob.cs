﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesRememberServices.Interface;
using Quartz;
using StructureMap;

namespace MoviesRememberServices.Utils
{
    public class AlertMovieJob : IJob
    {
        public AlertMovieJob()
        {
        }

        public void Execute(IJobExecutionContext context)
        {
            IUserService userService = ObjectFactory.GetInstance<IUserService>();
            userService.SendMoviesReleased();
        }
    }
}
