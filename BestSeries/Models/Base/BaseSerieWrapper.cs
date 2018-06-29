using System;
namespace BestSeries.Models.Base
{
    public abstract class BaseSerieWrapper
    {
        
        public long Id { get; set; }

        public string Name { get; set; }

        public string Popularity { get; set; }

        public string Overview { get; set; }

        public string PosterPath { get; set; }

        public string Poster { get; set; }

        public string BackdropPath { get; set; }

        public string Backdrop { get; set; }

        public DateTime FirstAirDate { get; set; }

        public double VoteAverage { get; set; }
    }
}
