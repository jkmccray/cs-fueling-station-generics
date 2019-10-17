using System;
using System.Collections.Generic;

namespace FuelingStations
{
    public interface IStation<TCar>
    {
        string Name { get; set; }
        int Capacity { get; set; }
        void Refuel(List<TCar> cars);
    }


}