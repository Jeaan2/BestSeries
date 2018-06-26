using System;
using BestSeries.Services.Navigation;
using BestSeries.ViewModels.Base;
using BestSeries.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BestSeries
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            BuildDependencies();
            InitNavigation();
        }

        public void BuildDependencies()
        {
            ViewModelLocator.Instance.Build();
        }

        async void InitNavigation()
        {
            var navigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
            await navigationService.InitializeAsync();
        }
    }
}
