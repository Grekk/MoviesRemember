using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MoviesRememberServices;

namespace MoviesRememberTest
{
    [TestFixture]
    public class SearchServiceTest
    {
        [Test]
        public void TheTest()
        {
            MoviesShowingService w = new MoviesShowingService();
            w.GetTopRankedMovies();
        }
    }
}
