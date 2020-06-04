using System;

namespace Inheritance_Vehicles
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Ram growls past you. RRrrrrrummbbble!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The truck slugishly turns {direction}.");
        }
    }
}