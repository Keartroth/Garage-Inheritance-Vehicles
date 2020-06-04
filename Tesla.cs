using System;

namespace Inheritance_Vehicles
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Tesla blazes by you. MMmmmmmmmmmmm!");
        }
    }
}