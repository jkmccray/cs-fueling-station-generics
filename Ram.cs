using System;

namespace GarysGarage
{
    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {

        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. RRrrrrrummbbble!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram squeals to a stop.");
        }
    }
}