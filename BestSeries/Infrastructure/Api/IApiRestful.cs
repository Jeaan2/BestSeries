using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BestSeries.Models;
using Refit;

namespace BestSeries.Infrastructure.Api
{
    [Headers("Content-Type: application/json")]
    public interface IApiRestful
    {
        [Get("/3/tv/popular?api_key={apiKey}")]
        Task<IEnumerable<Serie>> GetSeriesAsync(string apiKey);
    }
}
