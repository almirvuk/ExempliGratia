using ExempliGratia.Mobile.Models;
using Prism.Mvvm;
using Prism.Navigation;

namespace ExempliGratia.Mobile.ViewModels
{
    public class CarDetailsPageViewModel : BindableBase, INavigationAware
    {
        private string carTitle;
        public string CarTitle
        {
            get { return carTitle; }
            set { SetProperty(ref carTitle, value); }
        }

        private string photoUrl;
        public string PhotoUrl
        {
            get { return photoUrl; }
            set { SetProperty(ref photoUrl, value); }
        }

        public CarDetailsPageViewModel() {  }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("selectedCar"))
            {
                Car car = parameters.GetValue<Car>("selectedCar");

                if (car != null)
                {
                    CarTitle = $"{car.Make} {car.Model}";
                    PhotoUrl = car.PhotoUrl;
                }
            }
        }

        public void OnNavigatedFrom(INavigationParameters parameters) { }
    }
}
