using System;
using Newtonsoft.Json;

namespace BestSeries.Models
{
    public class BaseSerieResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("popularity")]
        public decimal Popularity { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("first_air_date")]
        public DateTime FirstAirDate { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        public string Backdrop 
        {
            get { return $"{AppSettings.ImageUrlPref}{BackdropPath}"; }
        }

        public string Poster 
        {
            get { return $"{AppSettings.ImageUrlPref}{PosterPath}"; }
        }

        public string ReleaseDate
        {
            get { return FirstAirDate.ToString("d"); }
        }

        public string PopularityRate
        {
            get { return Popularity.ToString("0.00"); }
        }
    }
}
