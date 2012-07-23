using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MoviesRememberDomain
{
    public class TinyMovie
    {
        public long Id { get; set; }

        public long ApiId { get; set; }
     
        public string PictureUrl { get; set; }

        public string Title { get; set; }

        private string _originalTitle = string.Empty;
        public string OriginalTitle
        {
            get
            {
                return  string.IsNullOrEmpty(Title) || _originalTitle.ToLowerInvariant() != Title.ToLowerInvariant() ? _originalTitle : string.Empty;
            }
            set
            {
                _originalTitle = value;
            }
        }

        public string Actors { get; set; }

        public string Director { get; set; }

        private decimal? _userRatings;
        public decimal? UserRatings
        {
            get
            {
                return _userRatings;
            }
            set
            {
                if(value != null)
                {
                    value = decimal.Round(value.Value, 2);
                }

                _userRatings = value;
            }
        }

        private decimal? _pressRatings;
        public decimal? PressRatings
        {
            get
            {
                return _pressRatings;
            }
            set
            {
                if (value != null)
                {
                    value = decimal.Round(value.Value, 2);
                }

                _pressRatings = value;
            }
        }

        public string Trailer { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ReleaseDate { get; set; }
    }
}
