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

        public ObservableCollection<SerieItemResponse> Items { get; }

        public MainViewModel(ISerieService serieService) : base("Best Series")
        {
            _serieService = serieService;

            ItemClickCommand = new Command<SerieItemWrapper>(async (item) => await ItemClickCommandExecuteAsync(item));
            Items = new ObservableCollection<SerieItemResponse>();
        }

        public override async Task InitializeAsync(object navigationData)
        {
            await base.InitializeAsync(navigationData);

            var result = await GetItemsAsync();
            Items.Clear();
            AddItems(result);
        }

        async Task ItemClickCommandExecuteAsync(SerieItemWrapper serie)
        {
            await NavigationService.NavigateToAsync<DetailsViewModel>(new SerieParameter
            {
                Id = serie.Id,
                Backdrop = serie.Backdrop,
                ReleaseDate = serie.ReleaseDate,
                Name = serie.Name,
                Overview = serie.Overview,
                PopularityRate = serie.PopularityRate,
                Poster = serie.Poster,
                VoteAverage = serie.VoteAverage

            });
        }

        async Task<SerieApiResponse> GetItemsAsync()
        => await _serieService.GetSeriesAsync();

        void AddItems(SerieApiResponse items)
        => items.Series?.ToList()?.ForEach(item => Items.Add(item));
    }
}
