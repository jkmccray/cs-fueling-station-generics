using System;
using System.Collections.Generic;

namespace FuelingStations
{
    public class BatteryStation : IStation<ElectricCar>
    {
        public string Name { get; set; }
        public int Capacity { get; set; } = 10;

        public void Refuel(List<ElectricCar> cars)
        {
            foreach (ElectricCar car in cars)
            {
                Console.WriteLine($"Refueling {car.Name}");
            }
        }
    }
}