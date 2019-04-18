using System.Collections.Generic;

namespace ConsoleApp
{
    public interface ICountryServices
    {
        IEnumerable<Country> GetAllCountries();
    }
}