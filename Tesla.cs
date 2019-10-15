using System;

namespace GarysGarage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. awooooga!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla zooms around a {direction} turn");
        }
    }
}