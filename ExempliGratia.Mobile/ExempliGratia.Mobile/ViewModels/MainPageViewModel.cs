using ExempliGratia.Mobile.Views;
using Prism.Commands;
using Prism.Navigation;

namespace ExempliGratia.Mobile.ViewModels
{
    public class MainPageViewModel
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand NavigateToCarListPageCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateToCarListPageCommand = new DelegateCommand(NavigateToCarListPage);
        }

        private async void NavigateToCarListPage()
        {
            await _navigationService.NavigateAsync(nameof(CarListPage));
        }
    }
}
