using System;
namespace BestSeries.Parameters
{
    public class SerieParameter
    {
        
        public long Id { get; set; }

        public string Name { get; set; }

        public decimal Popularity { get; set; }

        public string Overview { get; set; }

        public string PosterPath { get; set; }

        public string Poster { get; set; }

        public string BackdropPath { get; set; }

        public string Backdrop { get; set; }

        public DateTime FirstAirDate { get; set; }

        public string ReleaseDate { get; set; }

        public string PopularityRate { get; set; }

        public double VoteAverage { get; set; }
    }
}
