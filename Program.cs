using System;

namespace Inheritance_Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram truck = new Ram();

            truck.MainColor = "red";
            fxs.MainColor = "midnight blue";
            modelS.MainColor = "silver";
            mx410.MainColor = "white";

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine("");

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            Console.WriteLine("");

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            Console.WriteLine("");

            truck.Drive();
            truck.Turn("left");
            truck.Stop();
        }
    }
}