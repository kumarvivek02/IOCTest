using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {           
            IOCTest test = new IOCTest();
            test.buildServiceProvider();
            test.RetrieveInstance();
            test.GetListOfCountries();
            Console.ReadLine();
        }
    }

    public class IOCTest
    {
        private IServiceProvider _serviceProvider;
        private ICountryServices _countryServices;

        public void BuildServiceProvider()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<CountryServices>();
            
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        public void RetrieveInstance()
        {
            _countryServices = _serviceProvider.GetService<CountryServices>();
        }

        public void GetListOfCountries()
        {
            foreach (var country in _countryServices.GetAllCountries())
            {
                Console.WriteLine(country.Name +'\t'+ country.Code);
            };
        }

    }
}
