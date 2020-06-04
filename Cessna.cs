using System;

namespace Inheritance_Vehicles
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Cessna flashes by you. Zzzzzzoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The plane slowly banks {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Cessna rolls down the runway for a mile and stops.");
        }
    }
}