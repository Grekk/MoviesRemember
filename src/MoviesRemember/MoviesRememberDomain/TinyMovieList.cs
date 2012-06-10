﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesRememberDomain
{
    public class TinyMovieList
    {
        public TinyMovieList()
        {
            TinyMovies = new List<TinyMovie>();
        }

        public int Page { get; set; }
        public int Count { get; set; }
        public int TotalResult { get; set; }

        public IList<TinyMovie> TinyMovies { get; set; }

        public double NbWeek
        {
            get
            {
                return Math.Round((TinyMovies.Where(x => x.ReleaseDate.HasValue).ToList().Max(x => x.ReleaseDate.Value - DateTime.Now)).TotalDays / 7, 0);
            }
        }

        public int CurrentWeek { get; set; }

        public List<TinyMovie> GetMovieByWeek
        {
            get
            {
                DateTime start = DateTime.Today.AddDays(CurrentWeek * 7);
                DateTime end = start.AddDays(7);
                return TinyMovies.Where(m => m.ReleaseDate.HasValue && m.ReleaseDate.Value <= end && m.ReleaseDate.Value > start).ToList();
            }
        }
    }

    public enum OrderEnum
    {
        BY_DATE,

        BY_RANK
    }
}