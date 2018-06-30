using System;
using System.Threading.Tasks;
using BestSeries.Parameters;
using BestSeries.ViewModels.Base;

namespace BestSeries.ViewModels
{
    public class DetailsViewModel : ViewModelBase
    {
        

        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }

        }

        string _backdropPath;
        public string BackdropPath
        {
            get { return _backdropPath; }
            set { _backdropPath = value; OnPropertyChanged(); }
        }

        string _overview;
        public string Overview
        {
            get { return _overview; }
            set { _overview = value; OnPropertyChanged(); }
        }

        string _popularity;
        public string Popularity
        {
            get { return _popularity; }
            set { _popularity = value; OnPropertyChanged(); }
        }

        string _voteAverage;
        public string VoteAverage
        {
            get { return _voteAverage; }
            set { _voteAverage = value; OnPropertyChanged(); }
        }

        DateTime _firstAirDate;
        public string FirstAirDate
        {
            get { return _firstAirDate.ToString(); }
            set { _voteAverage = value; OnPropertyChanged(); }
        }

        public override async Task InitializeAsync(object parameter)
        {
            var serie = (parameter as SerieParameter);

            BackdropPath = serie.Backdrop;
            FirstAirDate = serie.FirstAirDate.ToString("d");
            Name = serie.Name;
            Overview = serie.Overview;

            VoteAverage = serie.VoteAverage.ToString("0.0f");

            await base.InitializeAsync(parameter);
        }

        public DetailsViewModel() : base("")
        {

        }
    }
}
