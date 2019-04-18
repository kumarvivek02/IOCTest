using System.Collections.Generic;

namespace ConsoleApp
{
    public class CountryServices : ICountryServices
    {
         
        public IEnumerable<Country> GetAllCountries()
        {
            return new List<Country>
            {
                new Country
                {
                    Name ="Australia",
                    Code =1
                },
                new Country
                {
                    Name ="Japan",
                    Code =2
                },
                new Country
                {
                    Name ="South Africa",
                    Code =3
                }
            };
        }
    }

}
