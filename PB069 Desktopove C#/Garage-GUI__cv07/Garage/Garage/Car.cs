using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Car
    {
        public string Manufacturer { get; private set; }

        public string Name { get; set; }

        public string LicensePlate { get; private set; }

        public decimal Price { get; private set; }

        public System.Drawing.Color Colour { get; set; }

        public decimal Fuel { get; set; }

        public TyreType Tyres { get; set; }

        public Car(string manufacturer, string licensePlate, decimal price)
        {
            Manufacturer = manufacturer;
            LicensePlate = licensePlate;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0} \"{1}\", {2}, Fuel: {3:00.0}%, {4} tyres, {5} euro", Manufacturer, Name, LicensePlate, Fuel, Tyres,Price);
        }
    }
}
