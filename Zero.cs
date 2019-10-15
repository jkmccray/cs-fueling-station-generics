using System;

namespace GarysGarage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {

        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past. boooooo");
        }
    }
}