using System;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero(){
                MainColor = "silver"
            };
            Tesla modelS = new Tesla(){
                MainColor = "turquoise"
            };
            Cessna mx410 = new Cessna(){
                MainColor = "purple"
            };
            Ram truck = new Ram(){
                MainColor = "red"
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            truck.Drive();
            fxs.Turn("left");
            modelS.Turn("right");
            mx410.Turn("left");
            truck.Turn("left");
            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            truck.Stop();
        }
    }
}
