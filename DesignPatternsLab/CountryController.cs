using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; }
        public CountryController()
        {
            this.CountryDb= new List<Country>();
        }
        public void CountryAction(Country c)
        {
            CountryView country = new CountryView(c);
            country.Display();
        }
        public void WelcomeAction()
        {
            CountryListView countries = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
            countries.Display();

            int input = Validator.ForceValidIndex(CountryDb.Count);

            CountryAction(CountryDb[input]);

            bool goOn = Validator.Continue();
            if (goOn)
            {
                WelcomeAction();
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
