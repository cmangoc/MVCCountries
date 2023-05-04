using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }
        public void Display()
        {
            Console.WriteLine("Country: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent);
            Console.WriteLine("Colors: ");
            for (int i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                if (DisplayCountry.Colors[i] == "Black")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(DisplayCountry.Colors[i]);
                    Console.ResetColor();
                }
                foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
                {
                    if (color.ToString() == DisplayCountry.Colors[i])
                    {
                        Console.ForegroundColor = color;
                        Console.WriteLine(DisplayCountry.Colors[i]);
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
