using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BestSeries.Models;

namespace BestSeries.Services
{
    public interface ISerieService
    {
        Task<IEnumerable<Serie>> GetSeriesAsync();
    }
}
