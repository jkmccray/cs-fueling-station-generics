using System;
using System.Collections.Generic;

namespace FuelingStations
{
    class Program
    {
        static void Main(string[] args)
        {
            GasCar cessna = new GasCar(){
                Name = "Cessna"
            };
            GasCar ram = new GasCar(){
                Name = "Ram"
            };
            ElectricCar leaf = new ElectricCar(){
                Name = "Leaf"
            };
            ElectricCar bolt = new ElectricCar(){
                Name = "Bolt"
            };

            List<GasCar> gasCars = new List<GasCar>(){
                cessna, ram
            };

            List<ElectricCar> electricCars = new List<ElectricCar>(){
                leaf, bolt
            };

            BatteryStation batteryStation = new BatteryStation();

            GasStation gasStation = new GasStation();

            batteryStation.Refuel(electricCars);

            gasStation.Refuel(gasCars);

        }
    }
}
