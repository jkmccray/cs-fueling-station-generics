using System;
using System.Collections.Generic;

namespace FuelingStations
{
    public class Station<TCar> : IStation<TCar> where TCar : ICar
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Refuel(List<TCar> cars)
        {
            foreach(TCar car in cars)
            {
                Console.WriteLine($"Refueling {car.Name}");
            }
        }
    }
}