using ExempliGratia.Mobile.Models;
using System.Collections.Generic;

namespace ExempliGratia.Mobile.Data
{
    public interface IDataProvider
    {
        IEnumerable<Car> GetData();
    }
}
