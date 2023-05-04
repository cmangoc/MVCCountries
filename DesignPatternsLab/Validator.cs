using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    public class Validator
    {
        public static int ForceValidIndex(int max)
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input >=0 && input < max)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Number out of range, try again: ");
                    return ForceValidIndex(max);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter an integer: ");
                return ForceValidIndex(max);
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Would you like to learn about another country?: [y/n]");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input, try again.");
                return Continue();
            }
        }
    }
}
