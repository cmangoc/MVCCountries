namespace DesignPatternsLab
{
    public class Program
    {
        static void Main()
        {
            CountryController countryController= new CountryController();
            countryController.CountryDb.Add(new Country("USA", "North America", (new List<string> { "Red", "White", "Blue" })));
            countryController.CountryDb.Add(new Country("Italy", "Europe", (new List<string> { "Green", "White", "Red" })));
            countryController.CountryDb.Add(new Country("Germany", "Europe", (new List<string> { "Black", "Red", "Yellow" })));

            countryController.WelcomeAction();
        }
    }
}