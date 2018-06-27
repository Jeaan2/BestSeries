using System;
using Newtonsoft.Json;

namespace BestSeries.Models
{
    public class SerieItemResponse : BaseSerieResponse
    {
       [JsonProperty("genre_ids")]
        public int[] GenreIds { get; set; }

    }
}
