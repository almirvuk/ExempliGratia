using ExempliGratia.Mobile.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ExempliGratia.Mobile.Data
{
    public class MockDataProvider : IDataProvider
    {
        public IEnumerable<Car> GetData()
        {
            return new ObservableCollection<Car>()
            {
                new Car()
                {
                    Make = "Audi",
                    Model = "R8",
                    PhotoUrl = "https://www.indigoautogroup.com/inventoryphotos/3228/wuakbafx3l7900354/ip/1.jpg?height=400"
                },

                new Car()
                {
                    Make = "BMW",
                    Model = "M5",
                    PhotoUrl = "https://s.aolcdn.com/dims-global/dims3/GLOB/legacy_thumbnail/640x400/quality/80/https://s.aolcdn.com/commerce/autodata/images/USC80BMC171A021001.jpg"
                },

                new Car()
                {
                    Make = "Lamborghini",
                    Model = "Veneno",
                    PhotoUrl = "https://www.automobilemag.com/uploads/sites/11/2020/01/2015-Lamborghini-Veneno-Roadster-10.jpg?fit=around%7C875:492"
                },

                new Car()
                {
                    Make = "Mercedes-AMG",
                    Model = " GT R",
                    PhotoUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2020-mercedes-amg-gt-r-pro-126-1554739776.jpg"
                }
            };
        }
    }
}
