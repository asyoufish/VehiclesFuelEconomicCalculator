using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace VehiclesFuelEconomicCalculator
{
    internal class Vehicle
    {
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public double Fuel { get; set; }
        public double Insurance { get; set; }
        public double Price { get; set; }
        public double Mains { get; set; }

        public Vehicle() { }
    }
}
