using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BestSeries.Infrastructure.Api;
using BestSeries.Models;

namespace BestSeries.Services
{
    public class SerieService : ISerieService
    {
        readonly IApiRestful _api;

        public SerieService(IApiRestful api)
        {
            _api = api;                
        }

        public Task<IEnumerable<Serie>> GetSeriesAsync()
        {
            return _api.GetSeriesAsync(AppSettings.ApiKey);
        }

    }
}
