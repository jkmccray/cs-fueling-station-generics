using System;

namespace GarysGarage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank() {  }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna drives past. awww yeahhhh");
        }
    }
}