using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class CarObject
    {
        //fields
        private string make;
        private string model;
        private int year;
        private double price;

        //properties

        public string MakeProperty
        {
            set { make = value; }
            get { return make; }
              
        }
        public string ModelProperty
        {
            set { model = value; }
            get { return model; }
        }
        public int YearProperty
        {
            set { year = value; }
            get { return year; }
        }
        public double PriceProperty
        {
            set { price = value; }
            get { return price; }
        }

        //Constructors

        public CarObject()
        {
            MakeProperty = "DEFAULT MAKE";
            ModelProperty = "DEFAULT MODEL";
            YearProperty = DateTime.Now.Year;
            PriceProperty = 1.00;
        }
        public CarObject(string makeinfo, string modelinfo, int yearinfo, double priceinfo)
        {
            MakeProperty = makeinfo;
            ModelProperty = modelinfo;
            YearProperty = yearinfo;
            PriceProperty = priceinfo;
        }
    }
}
