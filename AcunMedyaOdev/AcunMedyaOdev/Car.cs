using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaOdev
{
    internal class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double FuelConsumption { get; set; } 
        public double TotalDistance { get; set; }   

      
        public double CalculateFuelConsumption()
        {
            return (TotalDistance / 100) * FuelConsumption;
        }
    }
}
