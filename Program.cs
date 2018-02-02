using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! How many vehicles would you like to enter?");
            CarObject[] CarList = new CarObject[Validator.NumberofCars(Console.ReadLine())];
            for (int i = 0; i < CarList.Length; i++)
            {
                Console.Write($"Please enter vehicle #{i+1} make:");
                string InputMake = Validator.Make(Console.ReadLine());
                Console.Write($"Please enter vehicle #{i+1} model:");
                string InputModel = Console.ReadLine();
                Console.Write($"Please enter vehicle #{i+1} year:");
                int InputYear = Validator.Year(Console.ReadLine());
                Console.Write($"Please enter vehicle #{i+1} price:");
                double InputPrice = Validator.Price(Console.ReadLine());
                CarList[i] = new CarObject(InputMake,InputModel, InputYear, InputPrice);
            }
            Console.Clear();
            Console.WriteLine("The cars you entered are:");
            string StarBreak = new string('*',50);
            Console.WriteLine(StarBreak);
            foreach (CarObject item in CarList)
            {
                int Column = Console.CursorLeft;
                int Line = Console.CursorTop;
                Console.SetCursorPosition(Column, Line);
                Console.Write(item.MakeProperty);
                Console.SetCursorPosition(Column + 15, Line);
                Console.Write(item.ModelProperty);
                Console.SetCursorPosition(Column + 30, Line);
                Console.Write(item.YearProperty);
                Console.SetCursorPosition(Column + 60, Line);
                Console.WriteLine(String.Format("{0:C}", Convert.ToInt32(item.PriceProperty)));
            }
            Console.WriteLine(StarBreak);
        }
    }
}
