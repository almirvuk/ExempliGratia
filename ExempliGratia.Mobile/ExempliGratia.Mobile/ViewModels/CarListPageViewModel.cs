using ExempliGratia.Mobile.Data;
using ExempliGratia.Mobile.Models;
using ExempliGratia.Mobile.Views;
using Prism.Commands;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace ExempliGratia.Mobile.ViewModels
{
    public class CarListPageViewModel
    {
        private readonly INavigationService _navigationService;
        public ObservableCollection<Car> Cars { get; set; }

        public DelegateCommand<Car> SelectedCarCommand { get; private set; }

        public CarListPageViewModel(INavigationService navigationService, IDataProvider dataProvider)
        {
            _navigationService = navigationService;

            // Insert test data into collection of Cars
            Cars = new ObservableCollection<Car>(dataProvider.GetData());

            SelectedCarCommand = new DelegateCommand<Car>(SelectedCar);
        }

        private async void SelectedCar(Car selectedCar)
        {
            NavigationParameters navigationParameters = new NavigationParameters
            {
                { "selectedCar", selectedCar }
            };

            await _navigationService.NavigateAsync(nameof(CarDetailsPage), navigationParameters);
        }
    }
}
