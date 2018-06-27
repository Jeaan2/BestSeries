using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BestSeries.Models
{
    public class SerieApiResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results")]
        public IEnumerable<SerieItemResponse> Series { get; set; }


    }
}
