using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    public static class Validator
    {
        public static int NumberofCars(string Input)
        {
            while (!int.TryParse(Input, out int NewInput))
            {
                Console.WriteLine("Please enter a valid number!");
                Input = Console.ReadLine();
            }
            return int.Parse(Input);
        }
        public static string Make(string MakeInput)
        {
            while (!Regex.IsMatch(MakeInput, @"(^(Ford)$|^(Chrysler$)|^(Fiat)$|^(Dodge)$|^(Toyota)$|^(Cadillac)$)"))
            {
                Console.WriteLine("Please enter a vaild make.");
                MakeInput = Console.ReadLine();
            }
            return MakeInput;
        }
        public static int Year(string YearInput)
        {
            while (!Regex.IsMatch(YearInput, @"^(\d{4})"))
            {
                Console.WriteLine("Please enter a valid 4 digit year:");
                YearInput = (Console.ReadLine());
            }
            return int.Parse(YearInput);
        }
        public static double Price(string PriceInput)
        {
            while (!double.TryParse(PriceInput, out double NewPriceInput))
            {
                Console.WriteLine("Please enter a valid vehicle price.");
                PriceInput = Console.ReadLine();
            }
            return double.Parse(PriceInput);
        }
    }
}
