using System;
using BestSeries.ViewModels.Base;

namespace BestSeries.ViewModels
{
    public class DetailsViewModel : ViewModelBase
    {
        //Id = serie.Id,
        //BackdropPath = serie.BackdropPath,
        //FirstAirDate = serie.FirstAirDate,
        //Name = serie.Name,
        //Overview = serie.Overview,
        //Popularity = serie.Popularity,
        //PosterPath = serie.PosterPath,
        //VoteAverage = serie.VoteAverage

        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }

        }

        public DetailsViewModel() : base("")
        {

        }
    }
}
