using System;
using System.Collections.Generic;

namespace FuelingStations
{
    public class GasStation : IStation<GasCar>
    {
        public string Name { get; set; }
        public int Capacity { get; set; } = 10;

        public void Refuel(List<GasCar> cars)
        {
            foreach (GasCar car in cars)
            {
                Console.WriteLine($"Refueling {car.Name}");
            }
        }
    }
}