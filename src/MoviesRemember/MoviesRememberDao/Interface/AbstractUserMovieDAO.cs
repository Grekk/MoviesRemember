﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLSERVER_CONNECTION_STRING;

namespace MoviesRememberDao.Interface
{
    public abstract class AbstractUserMovieDAO : AbstractDAO<user_movie>
    {
        public AbstractUserMovieDAO(PetaPoco.Database db)
            :base(db)
        {
        }

        public abstract IList<user_movie> GetByUserId(Guid userId);
    }
}
