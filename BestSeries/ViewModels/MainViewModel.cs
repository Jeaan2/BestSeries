using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using BestSeries.Models;
using BestSeries.Parameters;
using BestSeries.Services;
using BestSeries.ViewModels.Base;
using Xamarin.Forms;

namespace BestSeries.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        readonly ISerieService _serieService;

        public ICommand ItemClickCommand { get; }

        public ObservableCollection<Serie> Items { get; }

        public MainViewModel(ISerieService serieService) : base("Best Series")
        {
            _serieService = serieService;

            ItemClickCommand = new Command<Serie>(async (item) => await ItemClickCommandExecuteAsync(item));
            Items = new ObservableCollection<Serie>();
        }

        public override async Task InitializeAsync(object navigationData)
        {
            await base.InitializeAsync(navigationData);

            var result = await GetItemsAsync();
            Items.Clear();
            AddItems(result);
        }

        async Task ItemClickCommandExecuteAsync(Serie serie)
        {
            await NavigationService.NavigateToAsync<DetailsViewModel>(new SerieParameter
            {
                Id = serie.Id,
                BackdropPath = serie.BackdropPath,
                FirstAirDate = serie.FirstAirDate,
                Name = serie.Name,
                Overview = serie.Overview,
                Popularity = serie.Popularity,
                PosterPath = serie.PosterPath,
                VoteAverage = serie.VoteAverage

            });
        }

        async Task<IEnumerable<Serie>> GetItemsAsync()
        => await _serieService.GetSeriesAsync();

        void AddItems(IEnumerable<Serie> items)
        => items?.ToList()?.ForEach(item => Items.Add(item));
    }
}
